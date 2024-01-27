using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterKitchen : MonoBehaviour
{
    public ServerController serverController;
    public BurgerSpawner burgerSpawner;
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
        burgerSpawner.kitchenDoor.SetActive(false);
        serverController.enterKitchenMode = true;
        Debug.Log("You've entered the kitchen.");

    }
}