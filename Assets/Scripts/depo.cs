using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class depo : MonoBehaviour
{
    Animator animasyon;
    int harekethash;
    public GameObject ok;
    public GameObject ok2;
    public GameObject yer;
    koliyer1 koli;
    Hareket hareket;
    uruncikisdepo uruncikisdepo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        koli = FindObjectOfType<koliyer1>();
        uruncikisdepo = FindObjectOfType<uruncikisdepo>();
        hareket = FindObjectOfType<Hareket>();
        animasyon =GetComponent<Animator>();
        harekethash = Animator.StringToHash("hareket");
        yer.GetComponent<Renderer>().enabled = false;
        ok.GetComponent<Renderer>().enabled = false;
        ok2.GetComponent<Renderer>().enabled = false;
       
        
        
    }

    // Update is called once per frame
    void Update()
    {   bool hepsiTrue = true;

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
             
           /* yer.GetComponent<Renderer>().enabled = true;
            ok.GetComponent<Renderer>().enabled = true;
            ok2.GetComponent<Renderer>().enabled = true;*/
            animasyon.SetBool("hareket", true);
            hareket.yer.GetComponent<Renderer>().enabled = false;
            hareket.ok.GetComponent<Renderer>().enabled = false;
            hareket.ok2.GetComponent<Renderer>().enabled = false;
            
        }
    }
}
