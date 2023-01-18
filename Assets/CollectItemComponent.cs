using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemComponent : MonoBehaviour
{
    public GameObject objectToEnable;

    void OnTriggerEnter(Collider other)
    {
        objectToEnable.SetActive(false);
    }
}
