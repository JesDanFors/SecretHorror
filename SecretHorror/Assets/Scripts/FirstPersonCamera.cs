using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    [SerializeField]
    float lookSpeed = 2.0f;
    [SerializeField]
    float lookXLimit = 45.0f;
    
    Camera playerCamera;
    float rotationX;
    
    // Start is called before the first frame update
    void Start(){
        playerCamera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update(){
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
    }

    void Interact(){
        //TODO: Look for interactables when raycasting
    }
}
