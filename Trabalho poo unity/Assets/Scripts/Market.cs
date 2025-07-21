using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Button botaoPlay;
    public Button botaoSettings;
    public Button botaoMarketplace;
    public AudioSource somClique;

    void Start()
    {
        botaoPlay.onClick.AddListener(() =>
        {
            somClique.Play();
            Invoke(nameof(CarregarJogo), 0.3f); // Troca de cena após o som
        });

        botaoSettings.onClick.AddListener(() =>
        {
            somClique.Play();
            Debug.Log("Settings clicado");
        });

        botaoMarketplace.onClick.AddListener(() =>
        {
            somClique.Play();
            Debug.Log("Marketplace clicado");
        });
    }

    void CarregarJogo()
    {
        SceneManager.LoadScene("Market"); // Troque para o nome real da cena
    }
}
