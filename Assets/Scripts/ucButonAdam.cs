using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucButonAdam : MonoBehaviour
{
    Animator animasyon;
    int calismaHash;
    koliyer2 koli;
    

    // Start is called before the first frame update
    void Start()
    {   
        animasyon =GetComponent<Animator>();
        calismaHash = Animator.StringToHash("calis");
        koli = FindObjectOfType<koliyer2>();
    }

    // Update is called once per frame
    void Update()
    {  bool hepsiTrue = true;

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
            bool calis=animasyon.GetBool(calismaHash);
            animasyon.SetBool("calis",true);
        }
        
    }
}
