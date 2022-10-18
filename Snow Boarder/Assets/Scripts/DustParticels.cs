using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustParticels : MonoBehaviour
{
    [SerializeField] ParticleSystem dustPatircel;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustPatircel.Play();
            
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustPatircel.Stop();
        }
    }
}
