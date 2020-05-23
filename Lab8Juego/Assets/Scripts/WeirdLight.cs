using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class WeirdLight : MonoBehaviour
{
    private Light luz;
    private int intensidad = 6;
    private int frecuencia = 4;

    void Start()
    {
        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (luz)
            luz.intensity = intensidad * Mathf.Sin(frecuencia * Time.time);
    }


    private void OnTriggerExit(Collider other)
    {
        if (luz)
            luz.intensity = 0;
    }
}
