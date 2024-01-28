using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaiterObstacle : MonoBehaviour
{
    public float timerOne;
    public float speed = 1.5f;
    public Rigidbody2D rb;
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    public Transform pointE;
    public Transform pointF;
    public Transform pointG;
    public Transform pointH;
    public Transform pointI;
    public Transform pointJ;
    public Transform pointK;
    public float timeSpacing = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        timerOne = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        timerOne += Time.deltaTime;

        if (timerOne >= 0 && timerOne < (1 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointA.position, step);
        }
        if (timerOne >= (1 * timeSpacing) && timerOne < (2 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointB.position, step);
        }
        if (timerOne >= (2 * timeSpacing) && timerOne < (3 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointC.position, step);
        }
        if (timerOne >= (3 * timeSpacing) && timerOne < (4 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointD.position, step);
        }
        if (timerOne >= (4 * timeSpacing) && timerOne < (5 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointE.position, step);
        }
        if (timerOne >= (5 * timeSpacing) && timerOne < (6 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointF.position, step);
        }
        if (timerOne >= (6 * timeSpacing) && timerOne < (7 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointG.position, step);
        }
        if (timerOne >= (7 * timeSpacing) && timerOne < (8 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointH.position, step);
        }
        if (timerOne >= (8 * timeSpacing) && timerOne < (9 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointI.position, step);
        }
        if (timerOne >= (9 * timeSpacing) && timerOne < (10 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointJ.position, step);
        }
        if (timerOne >= (10 * timeSpacing) && timerOne < (11 * timeSpacing))
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, pointK.position, step);
        }
        if (timerOne >= (11 * timeSpacing))
        {
            timerOne = 0;
        }
    }
    void FixedUpdate()
    {

    }
}
