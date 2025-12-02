
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    private const string _levelName = "Level1";

    public void OnButtonPlayClick()
    {
        SceneManager.LoadScene(_levelName);
    }

    public void OnButtonQuitClick()
    {
        Application.Quit(1);
    }
}
