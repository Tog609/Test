using UnityEngine;

public class PlayerCharger : MonoBehaviour
{
    [SerializeField] private ChargeMode _playerMode = ChargeMode.Plus;
    [SerializeField] private Material _playerMaterial;

    [SerializeField] private Color plusColor = new Color(0f, 0.8f, 1f);
    [SerializeField] private Color minusColor = new Color(0.7f, 0f, 1f);

    public ChargeMode Mode => _playerMode;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleCharge();
        }
    }

    private void ToggleCharge()
    {
        if (_playerMode == ChargeMode.Plus)
        {
            _playerMode = ChargeMode.Minus;
            _playerMaterial.SetColor("_EmissionColor", minusColor * 3f);
        }
        else if (_playerMode == ChargeMode.Minus)
        {
            _playerMode = ChargeMode.Plus;
            _playerMaterial.SetColor("_EmissionColor", plusColor * 3f);
        }
    }
}