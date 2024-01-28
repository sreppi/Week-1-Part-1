using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableServing : MonoBehaviour
{
    public GameObject table1;
    public GameObject table2;
    public GameObject table3;
    public GameObject table4;
    public GameObject table5;
    public GameObject table6;
    public GameObject table7;
    public GameObject table8;
    public GameObject table9;
    public GameObject table10;
    public GameObject table11;
    public GameObject table12;
    public GameObject table13;
    public GameObject table14;
    public GameObject table15;
    public bool servingMode;
    public int randomTable;

    void Start()
    {
        //Turn off all tables and serving mode at the start of the game.
        table1.SetActive(false);
        table2.SetActive(false);
        table3.SetActive(false);
        table4.SetActive(false);
        table5.SetActive(false);
        table6.SetActive(false);
        table7.SetActive(false);
        table8.SetActive(false);
        table9.SetActive(false);
        table10.SetActive(false);
        table11.SetActive(false);
        table12.SetActive(false);
        table13.SetActive(false);
        table14.SetActive(false);
        table15.SetActive(false);
        servingMode = false;
    }

    void Update()
    {
        if (servingMode == false) 
        {
            randomTable = Random.Range(1, 16); //Random number between 1-15, allows 1 table to be served.
        }
        if (servingMode == true)
        {
            if (randomTable == 1)
            {
                table1.SetActive(true);
            }
            if (randomTable == 2)
            {
                table2.SetActive(true);
            }
            if (randomTable == 3)
            {
                table3.SetActive(true);
            }
            if (randomTable == 4)
            {
                table4.SetActive(true);
            }
            if (randomTable == 5)
            {
                table5.SetActive(true);
            }
            if (randomTable == 6)
            {
                table6.SetActive(true);
            }
            if (randomTable == 7)
            {
                table7.SetActive(true);
            }
            if (randomTable == 8)
            {
                table8.SetActive(true);
            }
            if (randomTable == 9)
            {
                table9.SetActive(true);
            }
            if (randomTable == 10)
            {
                table10.SetActive(true);
            }
            if (randomTable == 11)
            {
                table11.SetActive(true);
            }
            if (randomTable == 12)
            {
                table12.SetActive(true);
            }
            if (randomTable == 13)
            {
                table13.SetActive(true);
            }
            if (randomTable == 14)
            {
                table14.SetActive(true);
            }
            if (randomTable == 15)
            {
                table15.SetActive(true);
            }
        }
    }
}
