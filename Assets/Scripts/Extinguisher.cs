using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour
{
    [SerializeField] private float amountExtinguishedPerSecond = 1.0f;
    public GameObject FireExtinguisher;
    public GameObject FireCamera;
    public GameObject Water;

    private ParticleSystem waterParticleSystem;
    private bool isExtinguishing = false;

    private void Start()
    {
        Water.SetActive(false);
        waterParticleSystem = Water.GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            if (!isExtinguishing)
            {
                isExtinguishing = true;
                Water.SetActive(true);
                waterParticleSystem.Play();
            }

            if (Physics.Raycast(FireCamera.transform.position, FireCamera.transform.forward, out RaycastHit hit, 100f) && hit.collider.TryGetComponent(out Fire fire))
            {
                fire.TryExtinguish(amountExtinguishedPerSecond * Time.deltaTime);
            }
        }
        else
        {
            if (isExtinguishing)
            {
                isExtinguishing = false;
                waterParticleSystem.Stop();
            }
        }
    }
}