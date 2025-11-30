using UnityEngine;

public class CubeMoveTest : MonoBehaviour
{   
    [Header("Character Settings")]
    public float moveTime = 0.15f;
    public float cellSize = 1f;

    private bool isMoving = false;

    private void Update()
    {
        if (!isMoving && Input.GetKeyDown(KeyCode.W))
        {
            Vector3 targetPos = transform.position + transform.forward * cellSize;
            StartCoroutine(MoveTo(targetPos));
        }
    }

    
    private System.Collections.IEnumerator MoveTo(Vector3 target)
    {
        isMoving = true;
        Vector3 start = transform.position;
        float t = 0;

        while (t < 1f)
        {
            t += Time.deltaTime / moveTime;
            transform.position = Vector3.Lerp(start, target, t);
            yield return null;
        }

        transform.position = target;
        isMoving = false;
    }
}
