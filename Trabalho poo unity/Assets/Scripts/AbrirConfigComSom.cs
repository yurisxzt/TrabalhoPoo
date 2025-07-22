using UnityEngine;
using UnityEngine.SceneManagement;

public class AbrirConfigComSom : MonoBehaviour
{
    public AudioSource somDeClique;

    public void IrParaConfiguracoes()
    {
        if (somDeClique != null)
        {
            somDeClique.Play();
            Invoke("CarregarCenaConfiguracoes", somDeClique.clip.length);
        }
        else
        {
            CarregarCenaConfiguracoes();
        }
    }

    void CarregarCenaConfiguracoes()
    {
        SceneManager.LoadScene("Settings");
    }
}
