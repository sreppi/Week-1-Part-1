using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(door.activeInHierarchy)
        {
            door.SetActive(false);
            spriteRenderer.color = Color.green;
        }
        else
        {
            door.SetActive(true);
            spriteRenderer.color = Color.red;
        }
    }
}
