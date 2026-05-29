using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public bool isOn = false;
    public bool workingLight = true;
    public float activeTime = 3f;
    public float cooldownTime = 2f;
    
    private Light lightComponent;
    private float lightTimer;
    private float cooldownTimer;


    private void Awake()
    {
        lightComponent = GetComponent<Light>();
        lightComponent.enabled = isOn;
    }

    private void Update()
    {
        if (isOn)
        {
            lightTimer -= Time.deltaTime;

            if (lightTimer <= 0f)
            {
                TurnOffAndCooldown();
            }
        }
        else if (!workingLight)
        {
            cooldownTimer -= Time.deltaTime;

            if (cooldownTimer <= 0f)
            {
                workingLight = true;
            }
        }
    }

    public void ActivateLight()
    {
        if (!workingLight) return;

        workingLight = false;
        isOn = true;
        lightTimer = activeTime;
        lightComponent.enabled = true;
    }

    private void TurnOffAndCooldown()
    {
        isOn = false;
        lightComponent.enabled = false;
        cooldownTimer = cooldownTime;
    }
}