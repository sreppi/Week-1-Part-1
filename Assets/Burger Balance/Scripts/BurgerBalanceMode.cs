using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerBalanceMode : MonoBehaviour
{
    public ServerController serverController;
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

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        serverController.enterKitchenMode = false;
        kitchenTrigger.SetActive(false);
        kitchenDoor.SetActive(true);
        burgerMode = true;
    }
}
