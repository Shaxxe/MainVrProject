using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class door : MonoBehaviour
{   
     
    Animator animasyon;
    int openhash;
    int closehash;
    public bool a=false;
    public Transform kapi;
    public float openy;
    public float closey;
    
    // Start is called before the first frame update
    void Start()
    {   
        XRSimpleInteractable Grabbable = GetComponent<XRSimpleInteractable>();
        Grabbable.selectExited.AddListener(col);
        animasyon =GetComponent<Animator>();
        openhash = Animator.StringToHash("open");
        closehash = Animator.StringToHash("close"); 
        
        
    }

    public void col(SelectExitEventArgs args) {
        a=true;
    } 
    // Update is called once per frame
     void FixedUpdate() {
    {   
         bool open=animasyon.GetBool(openhash);
         bool close=animasyon.GetBool(closehash);
         if(a)
            {
                if(kapi.eulerAngles.y==closey)
                {
                    animasyon.SetBool("close",true);
                    animasyon.SetBool("open",false);
                    a=false;
                    
                    
                }
                if(kapi.eulerAngles.y==openy)
                {
                    animasyon.SetBool("open",true);
                    animasyon.SetBool("close",false);  
                    a=false;
                }
                
                
            }
         
    }
}
}
