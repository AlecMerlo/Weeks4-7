using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class chestInteract : MonoBehaviour
{
    public GameObject interactText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            interactText.SetActive(false);
        }
    }
}
