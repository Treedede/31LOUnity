using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    bool canInteract = false;
    public GameObject objectToEnable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetButtonDown("Submit")&& canInteract)     
        {
        Debug.Log("b");
        objectToEnable.SetActive(true);
        }
    }


void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        Debug.Log("weszlo");
        canInteract = true;
    }
}

void OnTriggerExit(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
        {
            canInteract = false;
        }
}
}