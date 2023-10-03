using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundController : MonoBehaviour
{public AudioClip FireExtinguisherSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = FireExtinguisherSound;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
