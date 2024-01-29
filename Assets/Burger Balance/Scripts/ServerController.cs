using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ServerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject server;
    public bool wallBump;
    public bool onFood;
    public bool enterKitchenMode;
    public bool exitKitchenMode;
    Vector3 kitchenTransition = new Vector3(0, 0.1f, 0); //A variable that moves the player automatically
    public float timerOne;
    public bool disableControls;
    public BurgerBalanceMode burgerBalanceMode;
    public BurgerSpawner burgerSpawner;
    public TableServing tableServing;

    Vector2 direction;
    public float directionForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        wallBump = false;
        enterKitchenMode = false;
        exitKitchenMode = false;
        disableControls = false;
        timerOne = 0;
    }

    void Update()
    {
        if (enterKitchenMode == true || exitKitchenMode == true || burgerBalanceMode.burgerMode == true) //Took two hours to finally get the right solution!!!
        {
            disableControls = true;
        } else
        {
            disableControls = false;
        }

        if (disableControls == false)
        {
            direction.x = Input.GetAxis("Horizontal");
            direction.y = Input.GetAxis("Vertical");
        }

    }
    private void FixedUpdate()
    {
        rb.AddForce(direction * directionForce * Time.deltaTime);
        //Disable server controls and automatically move up into the kitchen.
        if (enterKitchenMode == true)
        {
            direction.x = 0; //This line stops the residual x movements when entering the kitchen door.
            direction.y = 1; //This line makes sure that the speed is always the same when entering and exiting.
            rb.transform.position += kitchenTransition * Time.deltaTime;
        } 
        //Moving out of the kitchen.
        if (exitKitchenMode == true)
        {
            direction.x = 0;
            direction.y = -1;
            rb.transform.position -= kitchenTransition * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Floor Food")
        {
            rb.drag = 0;
            onFood = true;
        }
        if (collision.tag == "Table")
        {
            //Only if you have at least ONE ingredient on the plate.
            if (burgerSpawner.topBunInstantiated == true ||
            burgerSpawner.pickleInstantiated == true ||
            burgerSpawner.tomatoInstantiated == true ||
            burgerSpawner.lettuceInstantiated == true ||
            burgerSpawner.cheeseInstantiated == true ||
            burgerSpawner.pattyInstantiated == true ||
            burgerSpawner.bottomBunInstantiated == true)
            {
                //Successful delivery. Might need to change this, maybe something that can group delete all this... Labels...?
                Destroy(burgerSpawner.topBun);
                Destroy(burgerSpawner.pickle);
                Destroy(burgerSpawner.tomato);
                Destroy(burgerSpawner.lettuce);
                Destroy(burgerSpawner.cheese);
                Destroy(burgerSpawner.patty);
                Destroy(burgerSpawner.bottomBun);

                burgerSpawner.topBunInstantiated = false;
                burgerSpawner.pickleInstantiated = false;
                burgerSpawner.tomatoInstantiated = false;
                burgerSpawner.lettuceInstantiated = false;
                burgerSpawner.cheeseInstantiated = false;
                burgerSpawner.pattyInstantiated = false;
                burgerSpawner.bottomBunInstantiated = false;

                tableServing.table1.SetActive(false);
                tableServing.table2.SetActive(false);
                tableServing.table3.SetActive(false);
                tableServing.table4.SetActive(false);
                tableServing.table5.SetActive(false);
                tableServing.table6.SetActive(false);
                tableServing.table7.SetActive(false);
                tableServing.table8.SetActive(false);
                tableServing.table9.SetActive(false);
                tableServing.table10.SetActive(false);
                tableServing.table11.SetActive(false);
                tableServing.table12.SetActive(false);
                tableServing.table13.SetActive(false);
                tableServing.table14.SetActive(false);
                tableServing.table15.SetActive(false);
                tableServing.servingMode = false;
            }
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
            //Debug.Log("You bumped into a wall.");
        }
    }
}
