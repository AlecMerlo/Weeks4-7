using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongLength : MonoBehaviour
{
    Slider slider;
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = music.clip.length;
        slider.value = music.time;
    }
}
