using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stars : MonoBehaviour
{
    float t = 0;
    public GameObject star;
    public GameObject spawn;
    public RectTransform canvas;

    // Start is called before the first frame update
    void Start()
    {
        star.transform.parent = spawn.transform;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        transform.position += Vector3.right * Time.deltaTime * 9 * 3;
        transform.position += Vector3.up * Time.deltaTime * 4 * 3;

        if (transform.position.x > canvas.sizeDelta.x) 
        {
            t = 0;
            Instantiate(star, new Vector3(-225,40,0),Quaternion.identity);
            Destroy(star);
        }
        
    }
}
