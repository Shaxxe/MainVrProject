using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonadam : MonoBehaviour
{
    tir door;
    bool basla;
    Animator animasyon;
    int calismaHash;
    int sagHash;
    public GameObject adamm;
    public Vector3 yön;
    public Vector3 yön2;
    public Vector3 yön3;
    public Vector3 yön4;
    /*public Vector3 yön5;

    public Vector3 yön6;*/



    Quaternion y;

    public float speedTranslate;
    public bool sol,soliki,sag,ileri;
    public bool a1=true,a2=true,a3=true;
    // Start is called before the first frame update
    void Start()
    {
        animasyon =GetComponent<Animator>();
        calismaHash = Animator.StringToHash("calis");
        sagHash = Animator.StringToHash("sag");
        door=FindObjectOfType<tir>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(door.buton==true)
        {
            bool calis=animasyon.GetBool(calismaHash);
            bool sag=animasyon.GetBool(sagHash);
            animasyon.SetBool("calis",true);
            
            if(animasyon.GetCurrentAnimatorStateInfo(0).IsTag("yurume") )
            {

                y = adamm.transform.localRotation;
                y.eulerAngles = new Vector3(adamm.transform.localRotation.x, 0, adamm.transform.localRotation.z);
                adamm.transform.localRotation = y;
                Vector3 currentPos = adamm.transform.localPosition; // Mevcut konumu alın
                Vector3 targetPos = new Vector3(currentPos.x, currentPos.y, yön.z); // Sadece X bileşenini hedefleyen bir konum oluşturun
                adamm.transform.localPosition = Vector3.MoveTowards(currentPos, targetPos, speedTranslate * Time.deltaTime);
                
                if(adamm.transform.localPosition.z==yön.z && a1)
                {
                   // Debug.Log("1");
                    y = adamm.transform.localRotation;
                    y.eulerAngles = new Vector3(adamm.transform.localRotation.x, 270, adamm.transform.localRotation.z);
                    adamm.transform.localRotation = y;
                    sol=true; 
                }
                if(sol)
                {
                   // Debug.Log("2");
                    Vector3 currentPos2 = adamm.transform.localPosition; // Mevcut konumu alın
                    Vector3 targetPos2 = new Vector3(yön2.x, currentPos2.y, currentPos2.z); // Sadece X bileşenini hedefleyen bir konum oluşturun
                    adamm.transform.localPosition = Vector3.MoveTowards(currentPos2, targetPos2, speedTranslate * Time.deltaTime);
                }
                if(adamm.transform.localPosition.x==yön2.x && a2)
                {   y = adamm.transform.localRotation;
                    y.eulerAngles = new Vector3(adamm.transform.localRotation.x, 180, adamm.transform.localRotation.z);
                    adamm.transform.localRotation = y;
                    sol=false;
                    a1=false;
                    soliki=true;
                   // Debug.Log("3");

                    
                }
                
                if(soliki)
                {
                    
                    Vector3 currentPos3 = adamm.transform.localPosition; // Mevcut konumu alın
                    Vector3 targetPos3 = new Vector3(currentPos3.x, currentPos3.y, yön3.z); // Sadece X bileşenini hedefleyen bir konum oluşturun
                    adamm.transform.localPosition = Vector3.MoveTowards(currentPos3, targetPos3, speedTranslate*0.05f);
                    Debug.Log("4");
                    
                    a2=false;
                }
                
               /* if(animasyon.GetCurrentAnimatorStateInfo(0).IsTag("yurume2") )
                {
                    Vector3 currentPos4 = adamm.transform.localPosition; // Mevcut konumu alın
                    Vector3 targetPos4 = new Vector3(yön4.x, currentPos4.y, currentPos4.z); // Sadece X bileşenini hedefleyen bir konum oluşturun
                    adamm.transform.localPosition = Vector3.MoveTowards(currentPos4, targetPos4, speedTranslate*0.05f);
                    Debug.Log("4");
                }*/
                   
            }
                

        }
    }
            
        
            
}

