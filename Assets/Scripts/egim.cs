using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egim : MonoBehaviour
{
   private vitesegim leveregim;
    //public float speed;
    //public float speedFork;
    public Transform direkegim1;
   // public Transform direktegim2;
    public Transform direkegim;
   // public Transform direkegim2;
   // public Transform direkegim3;
    
    //public Vector3 maxY; 
   // public Vector3 minY;
    // public Vector3 ForkmaxY; 
   // public Vector3 ForkminY;

    //private float  y;
    private Quaternion  x;
    public float rotationSpeed = 1f; // Dönme hızı
    //public float minRotationAngle = 0f; // Minimum dönme açısı
   // public float maxRotationAngle = -10f; // Maksimum dönme açısı
  


    // Start is called before the first frame update
    void Start () {
        // leverScript örneğini bulmak ve atamak için FindObjectOfType() kullanabilirsiniz
        leveregim = FindObjectOfType<vitesegim>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       float y=leveregim.vitesilk;
      // Debug.Log("y:"+y);
        float z=leveregim.vitesilk-0.1f;
        
        if ( 1>leveregim.vitesAngle )//yukarı && leveregim.vitesAngle<300
        {
            
           // y=0.5f;
            x=Quaternion.Euler(new Vector3(3f,0,0));
           // Vector3 movement = new Vector3(0f, y, 0f) * speed * Time.deltaTime;
            //Vector3 movementegim = new Vector3(0f, -y, 0f) * speed * Time.deltaTime;
            //direkegim1.Translate(movement);
            //direktegim2.Translate(movement);
            //direkegim1.transform.localPosition = Vector3.MoveTowards(direkegim1.transform.localPosition, ForkmaxY, speedFork * Time.deltaTime);
            //direktegim2.transform.localPosition = Vector3.MoveTowards(direktegim2.transform.localPosition, ForkmaxY, speedFork * Time.deltaTime);
            //direkegim.Translate(movementegim);
            //direkegim.Rotate(x * speed * Time.deltaTime,0f, 0f);
            
           // direkegim.transform.localPosition = Vector3.MoveTowards(direkegim.transform.localPosition, maxY, speedFork * Time.deltaTime);
            direkegim.localRotation = Quaternion.Slerp(direkegim.localRotation, x, rotationSpeed * Time.deltaTime);
           // direkegim2.rotation = Quaternion.Slerp(direkegim.rotation, x, rotationSpeed * Time.deltaTime);
            //direkegim3.rotation = Quaternion.Slerp(direkegim.rotation, x, rotationSpeed * Time.deltaTime);
                       
        }
        if (3.5<leveregim.vitesAngle )//aşağı && leveregim.vitesAngle<250  
        {
            //y=-0.5f;
             x=Quaternion.Euler(new Vector3(-10f,0,0));
            //Vector3 movement = new Vector3(0f, y, 0f) * speed * Time.deltaTime;
            //Vector3 movementegim = new Vector3(0f, -y, 0f) * speed * Time.deltaTime;
            //direkegim1.Translate(movement);
            //direktegim2.Translate(movement);
            //direkegim.Translate(movementegim);
           // direkegim1.transform.localPosition = Vector3.MoveTowards(direkegim1.transform.localPosition, ForkminY, speedFork * Time.deltaTime);
           // direktegim2.transform.localPosition = Vector3.MoveTowards(direktegim2.transform.localPosition, ForkminY, speedFork * Time.deltaTime);
         //direkegim.transform.localPosition = Vector3.MoveTowards(direkegim.transform.localPosition, minY, speedFork * Time.deltaTime);
           // direkegim.Rotate(x * speed * Time.deltaTime,0f, 0f);
            direkegim.localRotation = Quaternion.Slerp(direkegim.localRotation, x, rotationSpeed * Time.deltaTime);
          //  direkegim2.rotation = Quaternion.Slerp(direkegim.rotation, x, rotationSpeed * Time.deltaTime);
           // direkegim3.rotation = Quaternion.Slerp(direkegim.rotation, x, rotationSpeed * Time.deltaTime);
            
        }
    }
}
