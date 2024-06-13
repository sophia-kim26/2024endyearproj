using UnityEngine;
using UnityEngine.SceneManagement;
 
public class StartButtonAction : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("selectSong");
    }

    public void restartScene() {
        SceneManager.LoadScene("selectSong");
    }
}