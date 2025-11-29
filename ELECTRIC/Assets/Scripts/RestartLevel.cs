using UnityEngine;
using UnityEngine.SceneManagement;

public static class RestartLevel 
{
    public static void RestartLevelByDeath()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}