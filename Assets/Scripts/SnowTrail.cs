using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowParticles;
    int layerIndex = LayerMask.NameToLayer("Floor");
    
    void OnConllisionEnter2D()
    {
        if(collision.gameObject.layer == layerIndex)
        {
            snowParticles.Play();
        }
    }

    void OnCollisionExit2D()
    {
        if(collision.gameObject.layer == layerIndex)
        {
            snowParticles.Stop();
        }
    }
}