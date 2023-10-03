using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garajkapi : MonoBehaviour
{
    
    // Start is called before the first frame update
    tir door;
    bool basla;
    Animator animasyon;
    int acikHash;
    // Start is called before the first frame update
    void Start()
    {
        animasyon =GetComponent<Animator>();
        acikHash = Animator.StringToHash("acik");
        door=FindObjectOfType<tir>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(door.buton==true)
        {
            bool acik=animasyon.GetBool(acikHash);
            animasyon.SetBool("acik",true);
        }
        
    }
}
