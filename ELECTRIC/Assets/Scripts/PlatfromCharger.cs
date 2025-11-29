using UnityEngine;

public class PlatformCharger : MonoBehaviour
{
    [SerializeField] private float _rotate = 90f;
    [SerializeField] private bool _turnLeft = true;

    private bool _hasRotated = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (_hasRotated) return;

        if (collision.gameObject.CompareTag("Player"))
        {
            Transform playerTransform = collision.transform;

            float direction = _turnLeft ? -1f : 1f;

            playerTransform.Rotate(0, _rotate * direction, 0);

            _hasRotated = true;
            Debug.Log("LOl");
        }
    }
}
