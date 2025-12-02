using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishButtonLogic : MonoBehaviour
{
    [SerializeField] private string _nextLevelName;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(_nextLevelName);
        }
    }
}