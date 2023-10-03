using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adam : MonoBehaviour
{
    
    Animator animasyon;
    
    public GameObject adamm;
    public Vector3 yön;
    public Vector3 yön2;
    public Vector3 yön3;
    Quaternion y;

    public float speedTranslate;
    public bool sag=false;
    public bool geri=false;
    

    // Start is called before the first frame update
    void Start()
    {
        animasyon = GetComponent<Animator>(); 
        
    }

    // Update is called once per frame
    void Update()
    { 
    
         if(animasyon.GetCurrentAnimatorStateInfo(0).IsTag("yurume") )
        {
            Vector3 currentPos = adamm.transform.localPosition; // Mevcut konumu alın
            Vector3 targetPos = new Vector3(yön.x, currentPos.y, currentPos.z); // Sadece X bileşenini hedefleyen bir konum oluşturun
            adamm.transform.localPosition = Vector3.MoveTowards(currentPos, targetPos, speedTranslate * Time.deltaTime);
            if(adamm.transform.localPosition.x==yön.x)
            {
                sag=true;
                y = adamm.transform.localRotation;
                y.eulerAngles = new Vector3(adamm.transform.localRotation.x, 180, adamm.transform.localRotation.z);
                adamm.transform.localRotation = y;
            }
            if(sag)
            {
                Vector3 currentPos2 = adamm.transform.localPosition; // Mevcut konumu alın
                Vector3 targetPos2 = new Vector3(currentPos2.x, currentPos2.y, yön2.z); // Sadece X bileşenini hedefleyen bir konum oluşturun
                adamm.transform.localPosition = Vector3.MoveTowards(currentPos2, targetPos2, speedTranslate * Time.deltaTime);
                    
            }
            if(adamm.transform.localPosition.z==yön2.z)
            {   y = adamm.transform.localRotation;
                y.eulerAngles = new Vector3(adamm.transform.localRotation.x, 270, adamm.transform.localRotation.z);
                adamm.transform.localRotation = y;
                sag=false;
                geri=true;
                
            }
            
            if(geri)
            {
                Vector3 currentPos3 = adamm.transform.localPosition; // Mevcut konumu alın
                Vector3 targetPos3 = new Vector3(yön3.x, currentPos3.y, currentPos3.z); // Sadece X bileşenini hedefleyen bir konum oluşturun
                adamm.transform.localPosition = Vector3.MoveTowards(currentPos3, targetPos3, speedTranslate * 0.04f);
                gameObject.SetActive(false);
            }
        }
    }
}
