using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//read the camera to turn towards it

public class BillboardUi : MonoBehaviour
{
    private Camera playerCamera;

    private void Start()
    {
        playerCamera = Camera.main;
    }

    private void FixedUpdate()
    {
        LookAtPlayer();
    }

    private void LookAtPlayer()
    {
        transform.LookAt(transform.position + playerCamera.transform.rotation * Vector3.forward, playerCamera.transform.rotation * Vector3.up);
    }
}
