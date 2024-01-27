using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ServerController : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 direction;
    public float directionForce;
    public GameObject server;
    public bool wallBump;
    public bool onFood;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        wallBump = false;
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {
        rb.AddForce(direction * directionForce * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Floor Food")
        {
            rb.drag = 0;
            onFood = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Floor Food")
        {
            rb.drag = 3;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            wallBump = true;
            Debug.Log("You bumped into a wall.");
        }
    }

}
