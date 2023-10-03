using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class binme : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ilkalan;
    public GameObject player;
    public GameObject fork;
    public CharacterController XRrig;
    public Transform cameraa;
    public GameObject binisCam;
    public bool forkalan;
    public Collider yelek;
    public Collider kask;
    
 
    
    public bool isPlayerInside = false;
    
    // Start is called before the first frame update
    void Start()
    {
        XRSimpleInteractable grabbable = GetComponent<XRSimpleInteractable>();
        grabbable.selectExited.AddListener(col);
        
        
    }
    

    // Update is called once per frame
    
    public void col(SelectExitEventArgs arg)
    { 
        Quaternion angle=ilkalan.localRotation;
        player.transform.position=ilkalan.transform.position;
        player.transform.localRotation=angle;
        XRrig.height=0.05f;
        isPlayerInside = true;
        forkalan=true;
        yelek.isTrigger=true;
        kask.isTrigger=true;
        

       // Vector3 newPosition = binisCam.transform.position; // Mevcut pozisyonu al
       // newPosition.y = 0.5f; // Y pozisyonunu 0.5 birim olarak güncelle
       // binisCam.transform.position = newPosition; // Yeni pozisyonu nesneye uygula

        
    }
     void FixedUpdate()
    {
        if (isPlayerInside==true)
        {
            player.transform.position=new Vector3(ilkalan.transform.position.x,ilkalan.transform.position.y,ilkalan.transform.position.z);
            //Quaternion newRotation = player.transform.rotation;
           // newRotation.y =fork.transform.rotation.y;
           // player.transform.rotation = newRotation;
           cameraa.rotation=fork.transform.rotation;
           

            
        }
    }
}
