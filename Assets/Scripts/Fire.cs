using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fire : MonoBehaviour
{[SerializeField,Range(0f,1f)] private float currentIntensity=1.0f;
 private float [] startIntensities=new float[0];
 [SerializeField] private ParticleSystem []fireParticleSystems=new ParticleSystem[0];

 float timeLastWatered=0;
 [SerializeField] private float regenDelay=2.5f;
 [SerializeField] private float regenRate=.1f;

 private bool isLit=true;

 private void Start() {

    startIntensities=new float[fireParticleSystems.Length];
    for(int i=0;i<fireParticleSystems.Length;i++)
    {
         startIntensities[i]=fireParticleSystems[i].emission.rateOverTime.constant;
    }
 }


 private void Update() {

    if(isLit&& currentIntensity<1.0f&&Time.time-timeLastWatered>=regenDelay)
    {
      currentIntensity+=regenRate*Time.deltaTime;
      ChangeIntensity();
    }
 }

 public bool TryExtinguish(float amount)
{
   timeLastWatered=Time.time;
   currentIntensity-=amount;
   ChangeIntensity();
   if(currentIntensity<=0)
   {
      isLit=false;
      return true;
   }
   return false ;//fire is still lit 
}
 private void ChangeIntensity(){
    for(int i=0;i<fireParticleSystems.Length;i++)
    {
        var emission=fireParticleSystems[i].emission;
        emission.rateOverTime=currentIntensity*startIntensities[i];
    }

 }
}
