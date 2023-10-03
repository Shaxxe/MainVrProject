using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yanginbaslangic : MonoBehaviour
{
    uruncikis uruncikis; 
    koliyer3 koli;
    alarmson alarmson;
    public AudioClip FireAlarmSound;
    private AudioSource audioSource; 
    public bool a;
    public GameObject yangin;
    

    
    public bool alarmcalma;
    // Start is called before the first frame update
    void Start()
    {
        koli = FindObjectOfType<koliyer3>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = FireAlarmSound;
        uruncikis = FindObjectOfType<uruncikis>();
        alarmson=FindObjectOfType<alarmson>();
        yangin.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
         bool hepsiTrue = true;

        for (int i = 0; i < koli.koliSayisi; i++)
        {
            if (koli.koliDegerleri[i] == false)
            {
                hepsiTrue = false;
                break;
            }
        }

        if (hepsiTrue)
        {
            
            uruncikis.uruncikisyer.GetComponent<Renderer>().enabled = false;
            uruncikis.uruncikisok.GetComponent<Renderer>().enabled = false;
            uruncikis.uruncikisok2.GetComponent<Renderer>().enabled = false;
            
            
            if (!a)
            {
                alarmcalma=true;
                audioSource.Play(); 
                a=true;
                 yangin.SetActive(true);
                
            }else if (alarmson.alarmkapat)
            {
                audioSource.Stop();
                alarmcalma=false;
                
            }
                
            
            
        }
                
    }
}
