using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarcenaMarketplace : MonoBehaviour
{
    public AudioSource somClique;

    private void Awake()
    {
        // Garante que este objeto com som não seja destruído ao trocar de cena
        if (somClique != null && transform.parent == null)
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void IrParaCena(string nomeCena)
    {
        if (somClique != null)
        {
            somClique.Play();
            StartCoroutine(CarregarCenaComDelay(nomeCena));
        }
        else
        {
            SceneManager.LoadScene(nomeCena);
        }
    }

    private System.Collections.IEnumerator CarregarCenaComDelay(string nomeCena)
    {
        yield return new WaitForSeconds(somClique.clip.length);
        SceneManager.LoadScene(nomeCena);
    }

    public void VoltarCenaMenu()
    {
        string cenaAtual = SceneManager.GetActiveScene().name;

        if (cenaAtual == "Play" || cenaAtual == "Settings" || cenaAtual == "Marketplace")
        {
            if (somClique != null)
            {
                somClique.Play();
                StartCoroutine(CarregarCenaComDelay("Menu"));
            }
            else
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}

