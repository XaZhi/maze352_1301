using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        AudioManager.instance.PlayBGM(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Loading");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}