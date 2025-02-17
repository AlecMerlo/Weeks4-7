using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public Slider slider;
    public AudioSource music;
    public AudioClip bird;

    // Update is called once per frame
    void Update()
    {
        // setting the display of the time elapsed in the song to the time elaped in the song
        slider.value = music.time;
        
        // will play the bord sound when the song ends
        if(music.time >= music.clip.length - 0.02f && music.clip != bird && music.loop == false)
        {
            music.clip = bird;
            music.Play();
        }
    }
}
