using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class FlashLight : MonoBehaviour
{
    private bool isOn = true;
    private Light luz;
    private AudioSource switchSFX;

    void Start()
    {
        luz = GetComponent<Light>();
        switchSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (luz && Input.GetMouseButtonDown(0))
        {
            isOn = !isOn;
            luz.enabled = isOn; 
            if (switchSFX) switchSFX.Play();
        }
    }
}
