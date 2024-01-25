using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateController : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 direction;
    public float directionForce;
    public float angleForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        float angleDirection = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, angleDirection * angleForce * Time.deltaTime);

    }
    private void FixedUpdate()
    {
        rb.AddForce(direction * directionForce * Time.deltaTime);
    }
}
