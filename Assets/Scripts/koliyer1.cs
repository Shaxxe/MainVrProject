using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koliyer1 : MonoBehaviour
{
    public bool[] koliDegerleri; // Koli değerlerini tutacak bool dizisi
    public int koliSayisi;
    
    private void Start()
    {
       
        koliDegerleri = new bool[koliSayisi];
        for (int i = 0; i < koliSayisi; i++)
        {
            koliDegerleri[i] = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        string collidedObjectName = collision.gameObject.name;
        
        for (int i = 0; i < koliSayisi; i++)
        {
            string koliAdi = "koli" + (i + 1);
            
            if (collidedObjectName == koliAdi)
            {
                koliDegerleri[i] = true;
                Debug.Log(koliAdi + " çarpışması gerçekleşti.");
            }
        }
    }






}
