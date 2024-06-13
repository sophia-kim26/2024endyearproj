using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SongButtonAction : MonoBehaviour
{
    public void PlaySong()
    {
        SceneManager.LoadScene("gameplayScene");
    }
}