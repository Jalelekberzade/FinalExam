using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocolateMachine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="icechoco")
        {
            other.transform.GetChild(2).gameObject.SetActive(true);
            other.tag = "fruit";
        }
    }
}