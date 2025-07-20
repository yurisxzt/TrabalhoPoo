using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    public AudioSource somClique;

    public void IrParaCena(string nomeCena)
    {
        if (somClique != null)
        {
            somClique.Play(); // toca o som
            StartCoroutine(CarregarCenaComDelay(nomeCena)); // espera o som antes de trocar
        }
        else
        {
            SceneManager.LoadScene(nomeCena); // troca direto se não tiver som
        }
    }

    private System.Collections.IEnumerator CarregarCenaComDelay(string nomeCena)
    {
        yield return new WaitForSeconds(somClique.clip.length);
        SceneManager.LoadScene(nomeCena);
    }
}
