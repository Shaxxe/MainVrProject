using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uruncikis : MonoBehaviour
{
    public GameObject uruncikisyer;
    public GameObject uruncikisok;
    public GameObject uruncikisok2;
    koliyer2 koli;
    Animator animasyon;
    int harekethash;
    uruncikisdepo uruncikisdepo;
    depo depo;
    public AudioClip FireAlarmSound;
    private AudioSource audioSource;
    public bool ses = false;
   

    void Start()
    {
        koli = FindObjectOfType<koliyer2>();
        depo = FindObjectOfType<depo>();
        uruncikisdepo = FindObjectOfType<uruncikisdepo>();
        animasyon =GetComponent<Animator>();
        harekethash = Animator.StringToHash("hareket");
        uruncikisyer.GetComponent<Renderer>().enabled = false;
        uruncikisok.GetComponent<Renderer>().enabled = false;
        uruncikisok2.GetComponent<Renderer>().enabled = false;
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = FireAlarmSound;
        
    }

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

         if (hepsiTrue && !ses)
        {
            
            uruncikisyer.GetComponent<Renderer>().enabled = true;
            uruncikisok.GetComponent<Renderer>().enabled = true;
            uruncikisok2.GetComponent<Renderer>().enabled = true;
            animasyon.SetBool("hareket",true);
            uruncikisdepo.uruncikisdepoyer.GetComponent<Renderer>().enabled = false;
            uruncikisdepo.uruncikisdepook.GetComponent<Renderer>().enabled = false;
            uruncikisdepo.uruncikisdepook2.GetComponent<Renderer>().enabled = false;
            depo.yer.GetComponent<Renderer>().enabled = false;
            depo.ok.GetComponent<Renderer>().enabled = false;
            depo.ok2.GetComponent<Renderer>().enabled = false;
            PlayNextSound();
            ses = true;
        }
    }
    void PlayNextSound()
    {
        audioSource.Play();
    }
}
