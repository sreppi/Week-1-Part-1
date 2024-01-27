using System.Collections;
using System.Collections.Generic;
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
    int randomTiltSide;

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
                transform.Rotate(0, 0, Mathf.Sin(0.6f)); //Added a sin function here because I wanted to make a smoother rotation (Wasn't what I was looking for.)
                timerOne += Time.deltaTime;
            }
            if (randomTiltSide == 1)
            {
                transform.Rotate(0, 0, Mathf.Sin(-0.6f));
                timerOne += Time.deltaTime;
            }
        }
        if (timerOne >= 1)
        {
            transform.Rotate(0, 0, 0);
            serverController.wallBump = false;
            timerOne = 0;
            randomTiltSide = Random.Range(0, 2);
        }
    }
}
