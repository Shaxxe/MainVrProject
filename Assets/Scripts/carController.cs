using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class carController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    
    private bool isFren;
    private float currentFrenForce;
    private float currentDonusAcisi;
    //public InputActionProperty lpinchAnimationAction;
   // public InputActionProperty rpinchAnimationAction;
    // public InputActionProperty ltrigger;
   // public InputActionProperty rtrigger;
   // public float ltriggerValue;
//    public float rtriggerValue;
    //public bool altrigger;
    //public bool artrigger;

    [SerializeField] private float maxDonusAcisi;
    [SerializeField] public float motorTorqueForce;
    [SerializeField] private float brakeForce;


    [SerializeField] private WheelCollider onSolTekerlerkCollider;
    [SerializeField] private WheelCollider onSagTekerlerkCollider;
    [SerializeField] private WheelCollider arkaSolTekerlerkCollider;
    [SerializeField] private WheelCollider arkaSagTekerlerkCollider;

    [SerializeField] private Transform onSolTekerlekTransform;
    [SerializeField] private Transform onSagTekerlekTransform;
    [SerializeField] private Transform arkaSolTekerlekTransform;
    [SerializeField] private Transform arkaSagTekerlekTransform;
    public GameObject direksiyon; 
    //public  float steerInput;
    


    private void FixedUpdate() {
        //steerInput = direksiyon.transform.localRotation.y;
        //Debug.Log("açi"+steerInput);
        getUserInput();
        moveTheCar();
        rotateTheCar();
        rotateTheWheels();
    }

    private void rotateTheWheels(){
        
        rotateTheWheel(arkaSolTekerlerkCollider,arkaSolTekerlekTransform);
       rotateTheWheel(arkaSagTekerlerkCollider,arkaSagTekerlekTransform);
        rotateTheWheel(onSagTekerlerkCollider,onSagTekerlekTransform);
        rotateTheWheel(onSolTekerlerkCollider,onSolTekerlekTransform);
    }

    private void rotateTheWheel(WheelCollider tekerlerkCollider,Transform tekerlekTransform){
        Vector3 position;
        Quaternion rotation;
        tekerlerkCollider.GetWorldPose(out position,out rotation);
        tekerlekTransform.position=position;
        tekerlekTransform.rotation=rotation;
    }

    private void rotateTheCar(){
        currentDonusAcisi=maxDonusAcisi*direksiyon.transform.localRotation.z;
        onSolTekerlerkCollider.steerAngle=currentDonusAcisi;
        onSagTekerlerkCollider.steerAngle=currentDonusAcisi;


    }

    private void moveTheCar(){
    arkaSolTekerlerkCollider.motorTorque=verticalInput*motorTorqueForce;
        arkaSagTekerlerkCollider.motorTorque=verticalInput*motorTorqueForce;
        onSolTekerlerkCollider.motorTorque=verticalInput*motorTorqueForce;
        onSagTekerlerkCollider.motorTorque=verticalInput*motorTorqueForce;
        
        currentFrenForce=isFren ? brakeForce :0f; 
        if(isFren){
            onSolTekerlerkCollider.brakeTorque=currentFrenForce;
            onSagTekerlerkCollider.brakeTorque=currentFrenForce;
            arkaSolTekerlerkCollider.brakeTorque=currentFrenForce;
            arkaSagTekerlerkCollider.brakeTorque=currentFrenForce;
            arkaSolTekerlerkCollider.motorTorque=0;
            arkaSagTekerlerkCollider.motorTorque=0;
            onSolTekerlerkCollider.motorTorque=0;
            onSagTekerlerkCollider.motorTorque=0;
        }
        else
        {
            onSolTekerlerkCollider.brakeTorque=0f;
            onSagTekerlerkCollider.brakeTorque=0f;
            arkaSolTekerlerkCollider.brakeTorque=0f;
            arkaSagTekerlerkCollider.brakeTorque=0f;
            
        }
    }

    private void getUserInput(){
       horizontalInput=Input.GetAxis("Horizontal");
       verticalInput=Input.GetAxis("Vertical");
      // ltriggerValue = lpinchAnimationAction.action.ReadValue<float>();
       //rtriggerValue = rpinchAnimationAction.action.ReadValue<float>();
      // altrigger = ltrigger.action.triggered;
       //artrigger = rtrigger.action.triggered;
      //float gripValue = gripAnimationAction.action.ReadValue<float>();
        isFren=Input.GetKey(KeyCode.Joystick1Button0);
        if(Input.GetKeyDown(KeyCode.Joystick1Button1)){
            resetCarRotation();
        }

    }

    private void resetCarRotation(){
        Quaternion rotation=transform.rotation;
        rotation.z=0f;
        rotation.x=0f; 
        transform.rotation=rotation;
    }
 
}