using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void LoadCreateRoom()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void LoadJoinRoom()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void LoadSettings()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void ExitGame()
    {
            // If running inside the Unity Editor, stop playing the scene
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
    }
}
