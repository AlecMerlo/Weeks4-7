using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stars : MonoBehaviour
{
    public GameObject star;
    public GameObject spawn;
    public RectTransform canvas;

    // Start is called before the first frame update
    void Start()
    {
        star.transform.parent = spawn.transform;
        star.transform.localScale = Vector3.one * 6;
    }

    // Update is called once per frame
    void Update()
    {
        // moves as time goes along
        transform.position += Vector3.right * Time.deltaTime * 27;
        transform.position += Vector3.up * Time.deltaTime * 12;

        // when it passes the canvas
        if (transform.position.x > canvas.sizeDelta.x) 
        {
            // create a new one and destroy the old
            Instantiate(star, new Vector3(-225,40,0),Quaternion.identity);
            Destroy(star);
        }
        
    }
}
