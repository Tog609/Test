using UnityEngine;

public class PlatformMode : MonoBehaviour
{
    [SerializeField] private ChargeMode _mode;
    [SerializeField] private PlayerCharger _playerCharger;

    public ChargeMode Mode => _mode;

    private void PlatformCondition()
    {
        Debug.Log($"PlatformCondition вызван. Платформа={_mode}, Игрок={_playerCharger.Mode}");
        switch (_mode)
        {
            case ChargeMode.Minus:
                if (_playerCharger.Mode == ChargeMode.Plus)
                {
                    Destroy( _playerCharger.gameObject );
                    RestartLevel.RestartLevelByDeath();
                }
                break;

            case ChargeMode.Plus:
                if (_playerCharger.Mode == ChargeMode.Minus)
                {
                    Destroy(_playerCharger.gameObject);
                    RestartLevel.RestartLevelByDeath();
                }
                break;

            case ChargeMode.Trap:
                RestartLevel.RestartLevelByDeath();
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlatformCondition();
        }
    }
}
public enum ChargeMode { Minus, Plus, Trap }