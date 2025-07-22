using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    public AudioSource somClique;

    public void IrParaCena(string PLay)
    {
        if (somClique != null)
        {
            somClique.Play(); // toca o som
            StartCoroutine(CarregarCenaComDelay(PLay)); // espera o som antes de trocar
        }
        else
        {
            SceneManager.LoadScene(PLay); // troca direto se não tiver som
        }
    }

    private System.Collections.IEnumerator CarregarCenaComDelay(string Play)
    {
        yield return new WaitForSeconds(somClique.clip.length);
        SceneManager.LoadScene(Play);
    }
}
