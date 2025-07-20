using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource ambientSource;
    public AudioClip ambientClip;

    void Start()
    {
        ambientSource.clip = ambientClip;
        ambientSource.loop = true;
        ambientSource.Play();
    }
}
