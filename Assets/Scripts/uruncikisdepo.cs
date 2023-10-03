using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uruncikisdepo : MonoBehaviour
{
    public GameObject uruncikisdepoyer;
    public GameObject uruncikisdepook;
    public GameObject uruncikisdepook2;
    koliyer1 koli;
    depo depo;
    Hareket hareket;
    Animator animasyon;
    int harekethash;
    public AudioClip FireAlarmSound;
    private AudioSource audioSource;
    public bool ses = false;

    // Start is called before the first frame update
    void Start()
    {
        koli = FindObjectOfType<koliyer1>();
        hareket = FindObjectOfType<Hareket>();
        depo = FindObjectOfType<depo>();
        animasyon = GetComponent<Animator>();
        harekethash = Animator.StringToHash("hareket");
        uruncikisdepoyer.GetComponent<Renderer>().enabled = false;
        uruncikisdepook.GetComponent<Renderer>().enabled = false;
        uruncikisdepook2.GetComponent<Renderer>().enabled = false;
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = FireAlarmSound;
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

        if (hepsiTrue && !ses) // sesin bir kez çalmasını sağlamak için "ses" değişkenini kontrol ediyoruz
        {
            depo.yer.GetComponent<Renderer>().enabled = true;
            depo.ok.GetComponent<Renderer>().enabled = true;
            depo.ok2.GetComponent<Renderer>().enabled = true;
            animasyon.SetBool("hareket", true);
            uruncikisdepoyer.GetComponent<Renderer>().enabled = true;
            uruncikisdepook.GetComponent<Renderer>().enabled = true;
            uruncikisdepook2.GetComponent<Renderer>().enabled = true;
            PlayNextSound();
            ses = true; // sesin bir kez çalmasını sağlamak için "ses" değişkenini true olarak işaretliyoruz
        }
    }

    void PlayNextSound()
    {
        audioSource.Play();
    }
}
