using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class vitesegim : MonoBehaviour
{
    public HingeJoint leverJoint;
    private XRGrabInteractable grab;
     public GameObject vites2;
    public int aktif=0;
    public float initialRotationX;
    public float vitesAngle;
    public float vitesilk;
    

    public void Start()
    {
        grab = GetComponent<XRGrabInteractable>();
        grab.selectEntered.AddListener(OnGrabbed);
        grab.selectExited.AddListener(OnReleased);
        
        
    }

    public void OnGrabbed(SelectEnterEventArgs args)
    {
        aktif = 1;
        
        // Debug.Log("ilk:"+vitesilk);
    }

    public void OnReleased(SelectExitEventArgs args)
    {
        aktif = 2;
    }

    public void FixedUpdate()
    {   
 
         vitesAngle = vites2.transform.localRotation.x*-10;
          
        if (aktif==1)
        {
            leverJoint.limits = new JointLimits { min = -35f, max = 35f };
           vitesAngle = vites2.transform.localRotation.x*-10;
           
        }
        else if (aktif==2)
        {
            leverJoint.limits = new JointLimits { min = 0, max = 0 };
            
        }
    }
}

