using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth = 100;

    public float healthBarLength;

    // Use this for initialization
    void Start()
    {
        healthBarLength = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth < 0)
            curHealth = 0;

        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (maxHealth < 1)
            maxHealth = 1;

        healthBarLength = (Screen.width / 4) * (curHealth / (float)maxHealth);
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 40, healthBarLength, 20), curHealth + "/" + maxHealth);
    }
}

