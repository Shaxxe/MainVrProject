using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class Gorunurluk : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject objectToShow;

    private void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
        objectToShow.SetActive(false);
    }

    private void OnVideoEnd(UnityEngine.Video.VideoPlayer vp)
    {
        objectToShow.SetActive(true);
    }
}
