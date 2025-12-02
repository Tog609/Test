using UnityEngine;

public class PlatformCharger : MonoBehaviour
{
    [Header("Rotate Settings")]
    [SerializeField] private float _rotate = 90f;
    [SerializeField] private bool _turnLeft = true;

    private const string _playerTag = "Player";

    private bool _hasRotated = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (_hasRotated) return;
        Debug.Log("lol");

        if (collision.gameObject.CompareTag(_playerTag))
        {
            Transform playerTransform = collision.transform;

            float direction = _turnLeft ? -1f : 1f;

            playerTransform.Rotate(0, _rotate * direction, 0);

            _hasRotated = true;
        }
    }
}
