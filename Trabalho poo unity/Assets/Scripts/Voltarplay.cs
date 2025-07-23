using UnityEngine;
using UnityEngine.SceneManagement;

public class Voltarcena : MonoBehaviour
{
    public AudioSource somClique;

    public void IrParaCena(string PLay)
    {
        if (somClique != null)
        {
            somClique.Play();
            StartCoroutine(CarregarCenaComDelay(PLay));
        }
        else
        {
            SceneManager.LoadScene(PLay);
        }
    }

    private System.Collections.IEnumerator CarregarCenaComDelay(string Play)
    {
        yield return new WaitForSeconds(somClique.clip.length);
        SceneManager.LoadScene(Play);
    }

    public void VoltarCenaMenu()
    {
        if (SceneManager.GetActiveScene().name == "Play")
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
