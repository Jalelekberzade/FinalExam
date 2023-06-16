using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitmachine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.StartsWith("fruit"))
        {
            other.transform.GetChild(3).gameObject.SetActive(true);
        }
    }
}