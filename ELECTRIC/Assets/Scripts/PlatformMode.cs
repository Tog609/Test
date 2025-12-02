using UnityEngine;

public class PlatformMode : MonoBehaviour
{
    [Header("Platfrom modes")]
    [SerializeField] private ChargeMode _mode;
    [SerializeField] private PlayerCharger _playerCharger;

    private const string _playerTag = "Player";

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
                    RestartLevel.Instance.Restart();
                }
                break;

            case ChargeMode.Plus:
                if (_playerCharger.Mode == ChargeMode.Minus)
                {
                    Destroy(_playerCharger.gameObject);
                    RestartLevel.Instance.Restart();
                }
                break;

            case ChargeMode.Trap:
                RestartLevel.Instance.Restart();
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_playerTag))
        {
            PlatformCondition();
        }
    }
}
public enum ChargeMode { Minus, Plus, Trap }
