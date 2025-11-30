using UnityEngine;

public class CheckBound : MonoBehaviour
{
    private const  int _zeroNumber = 0;

    public void Update()
    {
        CheckBoundPosition();
    }
    void CheckBoundPosition()
    {
        if (transform.position.y <= _zeroNumber)
        {
            RestartLevel.Instance.Restart();
        }
    }
}
