using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forkalan : MonoBehaviour
{
    binme binme;
    public AudioClip FireAlarmSound;
    private AudioSource audioSource;

   
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;   
       
        binme=FindObjectOfType<binme>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = FireAlarmSound;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(!binme.forkalan)
        {
            if (other.CompareTag("Player"))
            {
                gameObject.GetComponent<Renderer>().enabled = true;   
                audioSource.Play();
            }
        }else{
            gameObject.GetComponent<Renderer>().enabled = false;  
        }
    

        
    }
      private void OnTriggerExit(Collider other) {
        
       
            gameObject.GetComponent<Renderer>().enabled = false;   
        
    }

    
}
