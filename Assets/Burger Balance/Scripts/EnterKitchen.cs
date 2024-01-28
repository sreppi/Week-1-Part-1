using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterKitchen : MonoBehaviour
{
    public ServerController serverController;
    public BurgerSpawner burgerSpawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Opens kitchen door and interacts with the serverController.
        burgerSpawner.kitchenDoor.SetActive(false);
        serverController.enterKitchenMode = true;
    }
}
