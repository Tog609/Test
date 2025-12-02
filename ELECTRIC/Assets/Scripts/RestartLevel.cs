using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel  : MonoBehaviour
{
    [Header("Instance")]
    public static RestartLevel Instance { get; private set; }


    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void Restart()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}