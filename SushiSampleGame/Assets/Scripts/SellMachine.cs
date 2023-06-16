using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellMachine : MonoBehaviour
{
    [SerializeField] Transform endTransform;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
        }
        else
        {
            StackHolder.Instance.coffeeList.Remove(other.transform);
            other.transform.DOMove(endTransform.position, 1);
        }
    }
}
