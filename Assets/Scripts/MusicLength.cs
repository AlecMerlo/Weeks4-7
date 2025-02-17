using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicLength : MonoBehaviour
{
    public AudioSource audioSource;

    public Slider slider;

    void Start()
    {
        Button button = GetComponent<Button>();

        button.onClick.AddListener(barSetup);
    }


    void barSetup()
    {
        // when clicked, set the timer to the song length and reset its value
        slider.maxValue = audioSource.clip.length - 0.01f;
        slider.value = 0;
    }
}
