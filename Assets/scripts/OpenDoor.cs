using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    public static bool eq1Enter;
    public static bool eq2Enter;
    public static bool eq3Enter;
    public static bool eq4Enter;
    private bool isOpenDoor;


    public void Start()
    {
        eq1Enter = false;
        isOpenDoor = true;
    }

    public void Update()
    {
        if (eq1Enter && eq2Enter && eq3Enter && eq4Enter && isOpenDoor)
        {
            //Debug.Log(standsCube1.transform.rotation.z);
            door.transform.localPosition += new Vector3(0,3f,0);
            isOpenDoor = false;
        }
    }    
}
