using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    Animator animasyon;
    int harekethash;
     public GameObject tirr;
    public Vector3 kapi;
    public GameObject ok;
     public GameObject ok2;
    public GameObject yer;
    
    // Start is called before the first frame update
    void Start()
    {
        animasyon =GetComponent<Animator>();
        harekethash = Animator.StringToHash("hareket");
        yer.GetComponent<Renderer>().enabled = false;
        ok.GetComponent<Renderer>().enabled = false;
        ok2.GetComponent<Renderer>().enabled = false;
       
    
    }

    // Update is called once per frame
     private void FixedUpdate() {
        bool harekeret=animasyon.GetBool(harekethash);  
      if(tirr.transform.localPosition.x==kapi.x)
        { 
            yer.GetComponent<Renderer>().enabled = true;
            ok.GetComponent<Renderer>().enabled = true;
            ok2.GetComponent<Renderer>().enabled = true;
            animasyon.SetBool("hareket",true);
            
            
        }
    }
}
