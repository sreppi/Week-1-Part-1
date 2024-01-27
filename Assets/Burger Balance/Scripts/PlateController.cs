using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlateController : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 direction;
    public float directionForce;
    public float angleForce;
    GameObject Server;
    public ServerController serverController;
    public float timerOne;
    public float timerTwo;  
    int randomTiltSide;
    public bool touchLeft;
    Vector3 repositionPlate = new Vector3(0.04f, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        randomTiltSide = 0;
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        //direction.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.AddForce(direction * directionForce * Time.deltaTime);
        float angleDirection = Input.GetAxis("Fire3");
        transform.Rotate(0, 0, angleDirection * angleForce * Time.deltaTime);

        if (serverController.wallBump == true)
        {
            if (randomTiltSide == 0)
            {
                transform.Rotate(0, 0, 2.5f);
                timerOne += Time.deltaTime;
            }
            if (randomTiltSide == 1)
            {
                transform.Rotate(0, 0, -2.5f);
                timerOne += Time.deltaTime;
            }
        }
        if (timerOne >= 0.2)
        {
            transform.Rotate(0, 0, 0);
            serverController.wallBump = false;
            timerOne = 0;
            randomTiltSide = Random.Range(0, 2);
        }

        if (serverController.onFood == true)
        {
            timerTwo += Time.deltaTime;
        }
        if (serverController.onFood == false)
        {
            timerTwo = 0;
        }

        if (timerTwo > 0)
        {
            if (randomTiltSide == 0)
            {
                if (timerTwo > 0 && timerTwo <= 0.2)
                {
                    transform.Rotate(0, 0, 2.5f);
                }
                if (timerTwo > 0.2 && timerTwo <= 0.4)
                {
                    transform.Rotate(0, 0, -2.5f);
                }
                if (timerTwo > 0.4 && timerTwo <= 0.6)
                {
                    transform.Rotate(0, 0, 2.5f);
                }
                if (timerTwo > 0.6 && timerTwo <= 0.8)
                {
                    transform.Rotate(0, 0, -2.5f);
                }
            }
            if (randomTiltSide == 1)
            {
                if (timerTwo > 0 && timerTwo <= 0.2)
                {
                    transform.Rotate(0, 0, -2.5f);
                }
                if (timerTwo > 0.2 && timerTwo <= 0.4)
                {
                    transform.Rotate(0, 0, 2.5f);
                }
                if (timerTwo > 0.4 && timerTwo <= 0.6)
                {
                    transform.Rotate(0, 0, -2.5f);
                }
                if (timerTwo > 0.6 && timerTwo <= 0.8)
                {
                    transform.Rotate(0, 0, 2.5f);
                }
            }

        }
        if (timerTwo > 0.8)
        {
            serverController.onFood = false;
            randomTiltSide = Random.Range(0, 2);
        }

            //Stops the plate from reaching off screen.
            if (transform.position.x < -4.5)
        {
            rb.transform.position += repositionPlate;
        }
        if (transform.position.x > 4.5)
        {
            rb.transform.position -= repositionPlate;
        }

    }

}
