using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objective4 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Vehicle")
        {
            //complete objective
            ObjectivesComplete.occurrence.ObjectiveFour(true);

            SceneManager.LoadScene("MainMenu");
        }
    }
}
