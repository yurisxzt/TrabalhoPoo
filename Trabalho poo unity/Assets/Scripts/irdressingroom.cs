using UnityEngine;
using UnityEngine.SceneManagement;

public class IrParaDressingRoom : MonoBehaviour
{
    public AudioSource somClique;

    public void CarregarDressingRoom()
    {
        if (somClique != null)
        {
            somClique.Play();
            StartCoroutine(TrocarDepoisDoSom());
        }
        else
        {
            SceneManager.LoadScene("DressingRoom");
        }
    }

    private System.Collections.IEnumerator TrocarDepoisDoSom()
    {
        yield return new WaitForSeconds(somClique.clip.length);
        SceneManager.LoadScene("DressingRoom");
    }
}