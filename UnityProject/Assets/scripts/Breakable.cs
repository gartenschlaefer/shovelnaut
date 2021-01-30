﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy if shovel hits object
        if (collision.CompareTag("ShovelHitbox"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().shovelMovesCount--;

            Destroy(gameObject);
        }
    }
}
