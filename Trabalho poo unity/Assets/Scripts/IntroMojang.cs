using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class IntroMojang : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string proximaCena = "MenuInicial"; 

    void Start()
    {
        videoPlayer.loopPointReached += QuandoTerminarVideo;
    }

    void QuandoTerminarVideo(VideoPlayer vp)
    {
        SceneManager.LoadScene(proximaCena);
    }
}
