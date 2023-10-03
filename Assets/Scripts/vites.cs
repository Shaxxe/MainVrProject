using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class vites : MonoBehaviour
{
    public HingeJoint leverJoint;
    public XRGrabInteractable grab;
  public GameObject vites2;
    public int aktif=0;
    public float minLimit;
    public float maxLimit;
    public float vitesAngle;

    public void Start()
    {
        grab = GetComponent<XRGrabInteractable>();
        grab.selectEntered.AddListener(OnGrabbed);
        grab.selectExited.AddListener(OnReleased);

        
    }

    public void OnGrabbed(SelectEnterEventArgs args)
    {
        aktif = 1;
    }

    public void OnReleased(SelectExitEventArgs args)
    {
        aktif = 2;
    }

    public void FixedUpdate()
    {   vitesAngle = vites2.transform.localRotation.x*-10;
          
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
