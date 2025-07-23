using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class FadeOutController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Image fadeImage;
    public float fadeDuration = 1.5f; // duração do fade em segundos
    public string proximaCena;

    private bool fadeIniciado = false;

    void Start()
    {
        videoPlayer.loopPointReached += QuandoVideoTermina;
    }

    void Update()
    {
        if (!fadeIniciado && videoPlayer.time >= videoPlayer.clip.length - fadeDuration)
        {
            fadeIniciado = true;
            StartCoroutine(FazerFadeOut());
        }
    }

    System.Collections.IEnumerator FazerFadeOut()
    {
        float t = 0;
        Color corInicial = fadeImage.color;
        Color corFinal = new Color(0, 0, 0, 1); // preto opaco

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            fadeImage.color = Color.Lerp(corInicial, corFinal, t / fadeDuration);
            yield return null;
        }
    }

    void QuandoVideoTermina(VideoPlayer vp)
    {
        SceneManager.LoadScene(proximaCena);
    }
}
