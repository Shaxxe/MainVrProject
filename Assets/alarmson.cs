using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarmson : MonoBehaviour
{
    // Start is called before the first frame update
    public bool alarmkapat;

    private void OnTriggerEnter(Collider other)
    {
        
            if (other.CompareTag("Player"))
            {
                alarmkapat=true;
            }

        
        }
}
