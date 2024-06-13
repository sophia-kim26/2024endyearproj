using UnityEngine;
using UnityEngine.SceneManagement;
 
public class StartButtonAction : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("selectSong");
    }
}