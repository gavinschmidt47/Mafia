using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayButtonPress()
    {
        SceneManager.LoadScene("Info");
    }
}
