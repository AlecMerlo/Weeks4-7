using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject enemyCreature;
    int health = 5;
    public TextMeshProUGUI healthIndicator;

    void Start()
    {
        healthIndicator.text = health.ToString();
    }

    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            health -= 1;
            if (health == 0)
            {
                Object.Destroy(enemyCreature);
            }
            healthIndicator.text = health.ToString();
        }
    }
}
