using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] AudioSource audioSource;
    [SerializeField] Toggle toggle;
    public void SetPause()
    {
        if (toggle.isOn)
        {
            audioSource.UnPause();
        }
        else
        {
            audioSource.Pause();
        }
            
    }

}
