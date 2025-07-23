using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class IntroMojang : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string proximaCena = "MenuInicial"; // Troque para o nome da sua próxima cena

    void Start()
    {
        videoPlayer.loopPointReached += QuandoTerminarVideo;
    }

    void QuandoTerminarVideo(VideoPlayer vp)
    {
        SceneManager.LoadScene(proximaCena);
    }
}
