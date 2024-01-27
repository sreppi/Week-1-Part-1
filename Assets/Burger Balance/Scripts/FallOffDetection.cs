using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOffDetection : MonoBehaviour
{
    public GameObject floorTopBunPrefab;
    public GameObject floorPicklePrefab;
    public GameObject floorTomatoPrefab;
    public GameObject floorLettucePrefab;
    public GameObject floorCheesePrefab;
    public GameObject floorPattyPrefab;
    public GameObject floorBottomBunPrefab;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        if (collision.tag == "TopBun")
            {
            Instantiate(floorTopBunPrefab, spawn.position, spawn.rotation);
            }
        if (collision.tag == "Pickle")
        {
            Instantiate(floorPicklePrefab, spawn.position, spawn.rotation);
        }
        if (collision.tag == "Tomato")
        {
            Instantiate(floorTomatoPrefab, spawn.position, spawn.rotation);
        }
        if (collision.tag == "Lettuce")
        {
            Instantiate(floorLettucePrefab, spawn.position, spawn.rotation);
        }
        if (collision.tag == "Cheese")
        {
            Instantiate(floorCheesePrefab, spawn.position, spawn.rotation);
        }
        if (collision.tag == "Patty")
        {
            Instantiate(floorPattyPrefab, spawn.position, spawn.rotation);
        }
        if (collision.tag == "BottomBun")
        {
            Instantiate(floorBottomBunPrefab, spawn.position, spawn.rotation);
        }
    }
}
