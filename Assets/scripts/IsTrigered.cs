using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrigered : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "eq1")
        {
            OpenDoor.eq1Enter = true;
            Debug.Log('Q');
        }
        if (other.tag == "eq2")
        {
            OpenDoor.eq2Enter = true;
            Debug.Log('Q');
        }
        if (other.tag == "eq3")
        {
            OpenDoor.eq3Enter = true;
            Debug.Log('Q');
        }
        if (other.tag == "eq4")
        {
            OpenDoor.eq4Enter = true;
            Debug.Log('Q');
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "eq1")
        {
            OpenDoor.eq1Enter = false;
            Debug.Log("Qq");
        }
        if (other.tag == "eq2")
        {
            OpenDoor.eq2Enter = false;
            Debug.Log("Qq");
        }
        if (other.tag == "eq3")
        {
            OpenDoor.eq3Enter = false;
            Debug.Log("Qq");
        }
        if (other.tag == "eq4")
        {
            OpenDoor.eq4Enter = false;
            Debug.Log("Qq");
        }
    }
}
