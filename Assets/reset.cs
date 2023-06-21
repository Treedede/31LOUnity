using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{

    public Transform transformToReset; 
    public Vector3 StartPoint;
    public Vector3 StartRotationAngles;
    public Quaternion StartRotation;
     //Start is called before the first frame update
    void Start()
    {
         if (transformToReset == null)
         {
             transformToReset = transform;
         }
         StartPoint = transformToReset.position;
         StartRotation = transformToReset.rotation;
         StartRotationAngles = StartRotation.eulerAngles;


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("p");
            transformToReset.position = StartPoint;
            transformToReset.eulerAngles = StartRotationAngles;
            transformToReset.rotation = StartRotation;



        }

    }
}
