using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitKitchen : MonoBehaviour
{
    public ServerController serverController;
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
        serverController.exitKitchenMode = true;
        Debug.Log("You've exited the kitchen.");
    }
}
