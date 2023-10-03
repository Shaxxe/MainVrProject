using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;



public class Gecis : MonoBehaviour
{   
    public string targetSceneName;
    bool baslat;
    // Start is called before the first frame update
    void Start()
    {
        XRSimpleInteractable grabbable = GetComponent<XRSimpleInteractable>();
        grabbable.selectExited.AddListener(col);
    }
    void col (SelectExitEventArgs args){
        SceneManager.LoadScene(targetSceneName);
    }

    // Update is called once per frame
    
}
