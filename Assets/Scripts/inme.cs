using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class inme : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform inis;
    public GameObject player;
    binme binme;
    public Collider yelek;
    public Collider kask;
    
 
    
    // Start is called before the first frame update
    void Start()
    {
        XRSimpleInteractable grabbable = GetComponent<XRSimpleInteractable>();
        grabbable.selectExited.AddListener(col);
        binme=FindObjectOfType<binme>();
    }

    // Update is called once per frame
    
    private void col(SelectExitEventArgs arg)
    {
       player.transform.position=inis.transform.position;
       binme.forkalan=false;
       Debug.Log(binme.forkalan);
       yelek.isTrigger=false;
       kask.isTrigger=false;
      
    }
   
}


