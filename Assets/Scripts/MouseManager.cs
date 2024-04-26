using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("Mouse Info")]
    public Vector3 clickStartLocation;

    [Header("Physics")]
    public Vector3 launchVector;
    public float launchForce;

    [Header("Slime")]
    public Transform slimeTransform;
    public Rigidbody slimeRigidbody;

    public Vector3 direction;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * 1f,
                mouseDifference.y * 1.2f,
                mouseDifference.y * 1.5f
            );
            launchVector.Normalize();
        }

        if (Input.GetMouseButtonUp(0))
        {
            print("Release!");
            slimeRigidbody.isKinematic = false;
            slimeRigidbody.AddForce(launchVector * launchForce * 75);


        }

        


    }

  
}
