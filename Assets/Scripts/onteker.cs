using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onteker : MonoBehaviour
{
    carController car;
   public float maxSteerAngle; // maksimum direksiyon açısı
    public WheelCollider wheelFL; // sol ön tekerlek collider'ı
    public WheelCollider wheelFR; // sağ ön tekerlek collider'ı
    public WheelCollider WheelRL;

    public WheelCollider WheelRR;

    public GameObject direksiyon; 
    public GameObject solon;
    public GameObject sagon;// kullanılacak direksiyon girdisi adı
    public GameObject solarka;

    public GameObject sagarka;


    private float currentSteerAngle; // şu anki direksiyon açısı
    void Start () {
        // leverScript örneğini bulmak ve atamak için FindObjectOfType() kullanabilirsiniz
        car = FindObjectOfType<carController>();
    }
    void FixedUpdate()
    {
        // direksiyon cihazından gelen girdiyi al
        float steerInput = direksiyon.transform.localEulerAngles.y;
       // Debug.Log("açı"+steerInput);
        // direksiyon açısını hesapla
        currentSteerAngle = steerInput * maxSteerAngle;

        // tekerlekleri döndür
         wheelFL.steerAngle = currentSteerAngle;
        wheelFR.steerAngle = currentSteerAngle;
        
    /* Quaternion newRotation = Quaternion.Euler(0, currentSteerAngle, 0);
        solon.transform.rotation = newRotation;
        Quaternion newRotation1 = Quaternion.Euler(0, currentSteerAngle, 0);
        sagon.transform.rotation = newRotation1;
       /* WheelRL.steerAngle = currentSteerAngle;
        WheelRR.steerAngle = currentSteerAngle;
        Quaternion newRotation2 = Quaternion.Euler(0, currentSteerAngle, 0);
        solarka.transform.rotation = newRotation2;
        Quaternion newRotation3 = Quaternion.Euler(0, currentSteerAngle, 0);
        sagarka.transform.rotation = newRotation3;*/
    }
}

