using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    [Range(0f,0.1f)]
    public float speed;
    
    void Update()
    {
        transform.position += Vector3.up * Input.GetAxisRaw("Vertical") * speed;
        transform.position += Vector3.right * Input.GetAxisRaw("Horizontal") * speed;
    }
}
