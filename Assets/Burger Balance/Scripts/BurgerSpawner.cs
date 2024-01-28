using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;
using static Cinemachine.CinemachineTriggerAction.ActionSettings;

public class BurgerSpawner : MonoBehaviour
{
    public BurgerBalanceMode burgerBalanceMode;
    public ServerController serverController;
    public TableServing tableServing;
    public GameObject kitchenDoor;
    public GameObject kitchenExitTrigger;
    public GameObject topBunPrefab;
    public GameObject topBun;
    public GameObject picklePrefab;
    public GameObject pickle;
    public GameObject tomatoPrefab;
    public GameObject tomato;
    public GameObject lettucePrefab;
    public GameObject lettuce;
    public GameObject cheesePrefab;
    public GameObject cheese;
    public GameObject pattyPrefab;
    public GameObject patty;
    public GameObject bottomBunPrefab;
    public GameObject bottomBun;
    public Transform spawn;
    public float timerOne;
    public bool bottomBunInstantiated;
    public bool pattyInstantiated;
    public bool cheeseInstantiated;
    public bool lettuceInstantiated;
    public bool tomatoInstantiated;
    public bool pickleInstantiated;
    public bool topBunInstantiated;
    public float spawnPosition;

    void Start()
    {
        timerOne = 0;
        kitchenExitTrigger.SetActive(false);
        spawnPosition = Random.Range(-1, 2);
    }

    void Update()
    {
        Vector3 xReposition = new Vector3(spawnPosition, 13, 0);
        if (timerOne >= 0.01 && timerOne < 2 && !bottomBunInstantiated)
        {
            bottomBun = Instantiate(bottomBunPrefab, xReposition, spawn.rotation);
            bottomBunInstantiated = true;
            spawnPosition = Random.Range(-1, 2);
        }
        if (timerOne >= 2 && timerOne < 4 && !pattyInstantiated)
        {
            patty = Instantiate(pattyPrefab, xReposition, spawn.rotation);
            pattyInstantiated = true;
            spawnPosition = Random.Range(-1, 2);
        }
        if (timerOne >= 4 && timerOne < 6 && !cheeseInstantiated)
        {
            cheese = Instantiate(cheesePrefab, xReposition, spawn.rotation);
            cheeseInstantiated = true;
            spawnPosition = Random.Range(-1, 2);
        }
        if (timerOne >= 6 && timerOne < 8 && !lettuceInstantiated)
        {
            lettuce = Instantiate(lettucePrefab, xReposition, spawn.rotation);
            lettuceInstantiated = true;
            spawnPosition = Random.Range(-1, 2);
        }
        if (timerOne >= 8 && timerOne < 10 && !tomatoInstantiated)
        {
            tomato = Instantiate(tomatoPrefab, xReposition, spawn.rotation);
            tomatoInstantiated = true;
            spawnPosition = Random.Range(-1, 2);
        }
        if (timerOne >= 10 && timerOne < 12 && !pickleInstantiated)
        {
            pickle = Instantiate(picklePrefab, xReposition, spawn.rotation);
            pickleInstantiated = true;
            spawnPosition = Random.Range(-1, 2);
        }
        if (timerOne >= 12 && timerOne < 14 && !topBunInstantiated)
        {
            topBun = Instantiate(topBunPrefab, xReposition, spawn.rotation);
            topBunInstantiated = true;
            spawnPosition = Random.Range(-1, 2);
        }
    }

    void FixedUpdate()
    {
        if (burgerBalanceMode.burgerMode == true)
        {
            timerOne += Time.deltaTime;
        }

        //Kitchen door is opened, and a exit trigger making the player move down automatically. This also makes server enter "serving mode" where they can deliever the food.
        if (timerOne >= 14)
        {
            kitchenDoor.SetActive(false);
            kitchenExitTrigger.SetActive(true);
            tableServing.servingMode = true;
        }
        //This is the end of Burger Building Mode
        if (timerOne >= 16)
        {
            burgerBalanceMode.burgerMode = false;
            timerOne = 0;
            serverController.exitKitchenMode = false;
            kitchenExitTrigger.SetActive(false);
            kitchenDoor.SetActive(true);
        }
    }
}
