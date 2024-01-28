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
    public BurgerSpawner burgerSpawner;
    public BurgerBalanceMode burgerBalanceMode;
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
        if (burgerBalanceMode.burgerMode == false)
        {
            Destroy(collision.gameObject);
            if (collision.tag == "TopBun")
            {
                Instantiate(floorTopBunPrefab, spawn.position, spawn.rotation);
                burgerSpawner.topBunInstantiated = false;
            }
            if (collision.tag == "Pickle")
            {
                Instantiate(floorPicklePrefab, spawn.position, spawn.rotation);
                burgerSpawner.pickleInstantiated = false;
            }
            if (collision.tag == "Tomato")
            {
                Instantiate(floorTomatoPrefab, spawn.position, spawn.rotation);
                burgerSpawner.tomatoInstantiated = false;
            }
            if (collision.tag == "Lettuce")
            {
                Instantiate(floorLettucePrefab, spawn.position, spawn.rotation);
                burgerSpawner.lettuceInstantiated = false;
            }
            if (collision.tag == "Cheese")
            {
                Instantiate(floorCheesePrefab, spawn.position, spawn.rotation);
                burgerSpawner.cheeseInstantiated = false;
            }
            if (collision.tag == "Patty")
            {
                Instantiate(floorPattyPrefab, spawn.position, spawn.rotation);
                burgerSpawner.pattyInstantiated = false;
            }
            if (collision.tag == "BottomBun")
            {
                Instantiate(floorBottomBunPrefab, spawn.position, spawn.rotation);
                burgerSpawner.bottomBunInstantiated = false;
            }
        }

        //This is so that burger pieces aren't being instantiated but also checking off the true and false statment.
        if (burgerBalanceMode.burgerMode == true)
        {
            Destroy(collision.gameObject);
            if (collision.tag == "TopBun")
            {
                burgerSpawner.topBunInstantiated = false;
            }
            if (collision.tag == "Pickle")
            {
                burgerSpawner.pickleInstantiated = false;
            }
            if (collision.tag == "Tomato")
            {
                burgerSpawner.tomatoInstantiated = false;
            }
            if (collision.tag == "Lettuce")
            {
                burgerSpawner.lettuceInstantiated = false;
            }
            if (collision.tag == "Cheese")
            {
                burgerSpawner.cheeseInstantiated = false;
            }
            if (collision.tag == "Patty")
            {
                burgerSpawner.pattyInstantiated = false;
            }
            if (collision.tag == "BottomBun")
            {
                burgerSpawner.bottomBunInstantiated = false;
            }
        }
    }
}
