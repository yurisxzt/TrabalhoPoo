using UnityEngine;
using UnityEngine.SceneManagement;

public class Trocando : MonoBehaviour
{
    public AudioSource somClique;

    public void IrParaCena(string nomeDaCena)
    {
        if (somClique != null)
        {
            somClique.Play();
        }

        SceneManager.LoadScene(nomeDaCena);
    }
}
