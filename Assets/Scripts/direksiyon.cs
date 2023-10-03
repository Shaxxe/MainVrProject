using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class direksiyon : MonoBehaviour
{
    public GameObject lhand;
    public GameObject rhand;
    public Transform newParent;
    public GameObject linteractor;
    public GameObject rinteractor;
    

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Right Hand") ) 
        {
            // do something
            XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
            grabbable.selectEntered.AddListener(ilksag);
            grabbable.selectExited.AddListener(sonsag);
            
        }
        else if(other.gameObject.CompareTag("Left Hand"))
        {
            XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
            grabbable.selectEntered.AddListener(ilksol);
            grabbable.selectExited.AddListener(sonsol);
        }
    }
    public void ilksag(SelectEnterEventArgs args)
    {
        rhand.transform.SetParent(newParent, true); 

        lhand.transform.SetParent(linteractor.transform, true);
        lhand.transform.localPosition = Vector3.zero;
        lhand.transform.localRotation=Quaternion.Euler(0,0,90); 
       
    }
    public void ilksol(SelectEnterEventArgs args)
    {
        lhand.transform.SetParent(newParent, true);  

        rhand.transform.SetParent(rinteractor.transform, true);
        rhand.transform.localPosition = Vector3.zero;
        rhand.transform.localRotation=Quaternion.Euler(0,0,-90);     
    }
    public void sonsag(SelectExitEventArgs args)
    {
        rhand.transform.SetParent(rinteractor.transform, true);
        rhand.transform.localPosition = Vector3.zero;
        rhand.transform.localRotation=Quaternion.Euler(0,0,-90);
        
    }
     public void sonsol(SelectExitEventArgs args)
    {
        lhand.transform.SetParent(linteractor.transform, true);
        lhand.transform.localPosition = Vector3.zero;
        lhand.transform.localRotation=Quaternion.Euler(0,0,90);
    }     
}
