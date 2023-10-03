using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarm : MonoBehaviour
{
    yanginbaslangic yanginbaslangic;
    public AudioClip FireAlarmSound;
    private AudioSource audioSource;
    int alarmHash;
    Animator animasyon;

    // Start is called before the first frame update
    void Start()
    {
        yanginbaslangic = FindObjectOfType<yanginbaslangic>();
        animasyon = GetComponent<Animator>();
        alarmHash = Animator.StringToHash("alarms");
    }

    // Update is called once per frame
    void Update()
    {
        bool alarms = animasyon.GetBool(alarmHash);

        if (yanginbaslangic.alarmcalma)
        { 
            animasyon.SetBool("alarms", true);
           
            
        }
        else
        {
            animasyon.SetBool("alarms", false);
            
        }
    }
}
