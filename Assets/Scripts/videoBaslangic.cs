using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class videoBaslangic : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public float delay = 5f;
    private bool hasStarted = false;

    void Start()
    {
        videoPlayer.Play();
        videoPlayer.Pause();
    }

    void Update()
    {
        if (!hasStarted && Time.time >= delay)
        {
            videoPlayer.Play();
            hasStarted = true;
        }
    }

}
