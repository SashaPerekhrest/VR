using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPuzzle : MonoBehaviour
{
    public GameObject eq1;
    public GameObject eq2;
    public GameObject eq3;
    public GameObject eq4;
    public GameObject rq1;
    public GameObject rq2;
    public GameObject rq3;
    public GameObject rq4;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "colon")
        {
            eq1.SetActive(true);
            eq2.SetActive(true);
            eq3.SetActive(true);
            eq4.SetActive(true);
            
            rq1.SetActive(true);
            rq2.SetActive(true);
            rq3.SetActive(true);
            rq4.SetActive(true);
        }
    }
}
