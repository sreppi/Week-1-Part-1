using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerBalanceMode : MonoBehaviour
{
    public ServerController serverController;
    public BurgerSpawner burgerSpawner;
    public GameObject kitchenTrigger;
    public GameObject kitchenDoor;
    public bool burgerMode;
    // Start is called before the first frame update
    void Start()
    {
        burgerMode = false;
        kitchenDoor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Once all pieces of the burger is served or dropped, open the kitchen doors.
        if (burgerSpawner.bottomBunInstantiated == false &&
            burgerSpawner.pattyInstantiated == false &&
            burgerSpawner.cheeseInstantiated == false &&
            burgerSpawner.lettuceInstantiated == false &&
            burgerSpawner.tomatoInstantiated == false &&
            burgerSpawner.pickleInstantiated == false &&
            burgerSpawner.topBunInstantiated == false &&
            burgerMode == false)
        {
            kitchenTrigger.SetActive(true);
            kitchenDoor.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        serverController.enterKitchenMode = false;
        kitchenTrigger.SetActive(false);
        kitchenDoor.SetActive(true);
        burgerMode = true;
        serverController.directionForce += 10; //Increase the speed each time you enter the kitchen... :)
    }
}
