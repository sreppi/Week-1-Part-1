using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Cinemachine.CinemachineTriggerAction.ActionSettings;

public class BurgerSpawner : MonoBehaviour
{
    public BurgerBalanceMode burgerBalanceMode;
    public ServerController serverController;
    public GameObject kitchenDoor;
    public GameObject kitchenExitTrigger;
    public GameObject topBunPrefab;
    public GameObject picklePrefab;
    public GameObject tomatoPrefab;
    public GameObject lettucePrefab;
    public GameObject cheesePrefab;
    public GameObject pattyPrefab;
    public GameObject bottomBunPrefab;
    public Transform spawn;
    public float timerOne;
    public bool bottomBunInstantiated;
    public bool pattyInstantiated;
    public bool cheeseInstantiated;
    public bool lettuceInstantiated;
    public bool tomatoInstantiated;
    public bool pickleInstantiated;
    public bool topBunInstantiated;
    // Start is called before the first frame update
    void Start()
    {
        timerOne = 0;
        kitchenExitTrigger.SetActive(false);
    }

    void Update()
    {
        if (timerOne >= 0.5f)
        {
            if (!bottomBunInstantiated)
            {
                Instantiate(bottomBunPrefab, spawn.position, spawn.rotation);
                bottomBunInstantiated = true;
            }
        }
        if (timerOne >= 3)
        {
            if (!pattyInstantiated)
            {
                Instantiate(pattyPrefab, spawn.position, spawn.rotation);
                pattyInstantiated = true;
            }
        }
        if (timerOne >= 4.5f)
        {
            if (!cheeseInstantiated)
            {
                Instantiate(cheesePrefab, spawn.position, spawn.rotation);
                cheeseInstantiated = true;
            }
        }
        if (timerOne >= 6)
        {
            if (!lettuceInstantiated)
            {
                Instantiate(lettucePrefab, spawn.position, spawn.rotation);
                lettuceInstantiated = true;
            }
        }
        if (timerOne >= 7.5f)
        {
            if (!tomatoInstantiated)
            {
                Instantiate(tomatoPrefab, spawn.position, spawn.rotation);
                tomatoInstantiated = true;
            }
        }
        if (timerOne >= 9)
        {
            if (!pickleInstantiated)
            {
                Instantiate(picklePrefab, spawn.position, spawn.rotation);
                pickleInstantiated = true;
            }
        }
        if (timerOne >= 10.5f)
        {
            if (!topBunInstantiated)
            {
                Instantiate(topBunPrefab, spawn.position, spawn.rotation);
                topBunInstantiated = true;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (burgerBalanceMode.burgerMode == true)
        {
            timerOne += Time.deltaTime;
        }

        if (timerOne >= 11)
        {
            kitchenDoor.SetActive(false);
            kitchenExitTrigger.SetActive(true);
        }
        if (timerOne >= 12.5)
        {
            burgerBalanceMode.burgerMode = false;
            timerOne = 0;
            serverController.exitKitchenMode = false;
            kitchenDoor.SetActive(true);
        }
    }
}
