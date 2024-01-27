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
    public bool enterKitchenMode;
    Vector3 kitchenTransition = new Vector3(0, 0.1f, 0);
    public float timerOne;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        wallBump = false;
        enterKitchenMode = false;
        timerOne = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (enterKitchenMode == false)
        {
            direction.x = Input.GetAxis("Horizontal");
            direction.y = Input.GetAxis("Vertical");
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(direction * directionForce * Time.deltaTime);
        if (enterKitchenMode == true)
        {
            direction.x = 0; //This line stops the residual x movements when entering the kitchen door.
            direction.y = 1;
            rb.transform.position += kitchenTransition * Time.deltaTime;
        }
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
