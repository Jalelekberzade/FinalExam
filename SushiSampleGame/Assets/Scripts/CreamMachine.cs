using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreamMachine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.StartsWith("Col"))
        {
            other.transform.GetChild(0).gameObject.SetActive(true);
            other.tag = "icecream";
        }
        else
        {
            other.transform.GetChild(1).gameObject.SetActive(true);
            other.tag = "icechoco";
        }
    }
}
