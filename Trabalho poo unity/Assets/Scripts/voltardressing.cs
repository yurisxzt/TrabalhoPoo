using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarParaMenu : MonoBehaviour
{
    public AudioSource somClique;

    public void Voltar()
    {
        if (somClique != null)
        {
            somClique.Play();
            StartCoroutine(TrocarDepoisDoSom());
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }

    private System.Collections.IEnumerator TrocarDepoisDoSom()
    {
        yield return new WaitForSeconds(somClique.clip.length);
        SceneManager.LoadScene("Menu");
    }
}