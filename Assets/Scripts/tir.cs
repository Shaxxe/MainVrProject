using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tir : MonoBehaviour
{
    Animator animasyon;
    int tirDurdumuHash;
    int YavasladimiHash;
    public GameObject tirr;
    public Vector3 kapi;
    public float speedTranslate;
    public float tiraci1;
    public float tiraci2;
    public bool buton;


    // Start is called before the first frame update
    void Start()
    {
        animasyon =GetComponent<Animator>();
        tirDurdumuHash = Animator.StringToHash("tirDurdumu");
        YavasladimiHash = Animator.StringToHash("Yavasladimi");

    }

    // Update is called once per frame
    void Update()
    {  
         
            bool Yavasladimi=animasyon.GetBool(YavasladimiHash);
            bool tirDurdumu=animasyon.GetBool(tirDurdumuHash);
            Vector3 currentPos = tirr.transform.localPosition; // Mevcut konumu alın
            Vector3 targetPos = new Vector3(kapi.x, currentPos.y, currentPos.z); // Sadece X bileşenini hedefleyen bir konum oluşturun
            tirr.transform.localPosition = Vector3.MoveTowards(currentPos, targetPos, speedTranslate * Time.deltaTime);
            //-175<-170//-175-175
            if(tirr.transform.localPosition.x<tiraci1 && tirr.transform.localPosition.x>kapi.x)// 
            {
                animasyon.SetBool("Yavasladimi",true);
                
            }
            if(tirr.transform.localPosition.x>tiraci2 && tirr.transform.localPosition.x<kapi.x)// 
            {
                animasyon.SetBool("Yavasladimi",true);
            }
            if(tirr.transform.localPosition.x==kapi.x)
            {
                animasyon.SetBool("tirDurdumu",true);
                buton=true;

            }
        
    }
}
