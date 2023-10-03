using UnityEngine;
using System.Collections;

using UnityEngine.InputSystem;
public class forkController : MonoBehaviour {

    public Transform fork; 
    
    private vites vites;
    public Transform mast;
    public float speedTranslate; //Platform travel speed
    public Vector3 maxY; //The maximum height of the platform
    public Vector3 minY; //The minimum height of the platform
    public Vector3 maxYmast; //The maximum height of the mast
    public Vector3 minYmast; //The minimum height of the mast

    private bool mastMoveTrue = false; //Activate or deactivate the movement of the mast

    // Update is called once per frame
    void Start () {
        // leverScript örneğini bulmak ve atamak için FindObjectOfType() kullanabilirsiniz
        vites = FindObjectOfType<vites>();
    }

    void FixedUpdate () {

        
        
        

        if(fork.transform.localPosition.z >= maxYmast.z && fork.transform.localPosition.z < maxY.z)
        {
            mastMoveTrue = true;
          

        }
        else
        {
            mastMoveTrue = false;

        }

        if (fork.transform.localPosition.z <= maxYmast.z)
        {
            mastMoveTrue = false;
        }
      
        
        if (1>vites.vitesAngle )
        //if (Input.GetKey(KeyCode.Joystick1Button0))
        {
           //fork.Translate(Vector3.up * speedTranslate * Time.deltaTime);
            fork.transform.localPosition = Vector3.MoveTowards(fork.transform.localPosition, maxY, speedTranslate * Time.deltaTime);
        
            if(mastMoveTrue)
            {
                mast.transform.localPosition = Vector3.MoveTowards(mast.transform.localPosition, maxYmast, speedTranslate * Time.deltaTime);
            }
          
        }
        
        if (3.5<vites.vitesAngle)
        //if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            fork.transform.localPosition = Vector3.MoveTowards(fork.transform.localPosition, minY, speedTranslate * Time.deltaTime);

            if (mastMoveTrue)
            {
                mast.transform.localPosition = Vector3.MoveTowards(mast.transform.localPosition, minYmast, speedTranslate * Time.deltaTime);

            }

        }
       

    }
}
