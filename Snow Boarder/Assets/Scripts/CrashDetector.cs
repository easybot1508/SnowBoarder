using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float timeLoadScene = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashAudio;
    bool hasCrashed = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;    
            GetComponent<PlayerController>().DisableControlers();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashAudio); 
            Invoke("ReloadScene", timeLoadScene);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }


}
