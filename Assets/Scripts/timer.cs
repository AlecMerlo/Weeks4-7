using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Slider slider;
    float t;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    
    void Update()
    {
        t += Time.deltaTime;
        t %= slider.maxValue;
        slider.value = t;
    }
}
