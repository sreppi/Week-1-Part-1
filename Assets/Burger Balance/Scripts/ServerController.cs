using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerController : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 direction;
    public float directionForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
}
