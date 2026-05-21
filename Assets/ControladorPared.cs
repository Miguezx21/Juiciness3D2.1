using UnityEngine;

public class ControladorPared : MonoBehaviour
{
    [Header("Arrastra aquí el objeto de la Pared física")]
    public GameObject wall;

    private Animator miAnimator;
    private AudioSource miAudioSource;

    void Start()
    {
        if (wall != null)
        {
            miAnimator = wall.GetComponent<Animator>();
            miAudioSource = wall.GetComponent<AudioSource>();
        }
        else
        {
            miAnimator = GetComponent<Animator>();
            miAudioSource = GetComponent<AudioSource>();
        }
    }

    public void EjecutarEfectoVictoria()
    {
        // Cambiado a "wall" para que coincida exactamente con tu animación
        if (miAnimator != null)
        {
            miAnimator.SetTrigger("wall");
        }
        else
        {
            Debug.LogError("¡No se encontró el Animator!");
        }

        if (miAudioSource != null)
        {
            miAudioSource.Play();
        }
        else
        {
            Debug.LogError("¡No se encontró el AudioSource!");
        }
    }
}