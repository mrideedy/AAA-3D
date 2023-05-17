using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //complete objective
            ObjectivesComplete.occurrence.ObjectiveThree(true);

            Destroy(gameObject, 2f);
        }
    }
}
