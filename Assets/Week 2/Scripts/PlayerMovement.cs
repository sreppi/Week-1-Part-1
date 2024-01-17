using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rb;
    public float force;
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
        rb.AddForce(direction * force * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("player hit something");
    }
}
