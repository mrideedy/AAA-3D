using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectivesComplete : MonoBehaviour
{
    [Header("Objectives to Complete")]
    public Text objective1;
    public Text objective2;
    public Text objective3;
    public Text objective4;

    public static ObjectivesComplete occurrence;

    private void Awake()
    {
        occurrence = this;
    }


    public void ObjectiveOne(bool obj1)
    {
        if (obj1 == true)
        {
            objective1.text = "1. Completed";
            objective1.color = Color.green;
        }
        else
        {
            objective1.text = "01. FIND THE RIFLE";
            objective1.color = Color.white;
        }
    }
    public void ObjectiveTwo(bool obj2)
    {
        if (obj2 == true)
        {
            objective2.text = "2. Completed";
            objective2.color = Color.green;
        }
        else
        {
            objective2.text = "02. FIND VEHICLE";
            objective2.color = Color.white;
        }
    }
    public void ObjectiveThree(bool obj3)
    {
        if (obj3 == true)
        {
            objective3.text = "3. Completed";
            objective3.color = Color.green;
        }
        else
        {
            objective3.text = "03. LOCATE THE VILLAGERS";
            objective3.color = Color.white;
        }
    }
    public void ObjectiveFour(bool obj4)
    {
        if (obj4 == true)
        {
            objective4.text = "4. Completed";
            objective4.color = Color.green;
        }
        else
        {
            objective4.text = "04. GET ALL VILLAGERS INTO VEHICLE";
            objective4.color = Color.white;
        }
    }
}

