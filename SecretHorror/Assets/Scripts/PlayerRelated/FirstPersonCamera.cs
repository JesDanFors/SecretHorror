using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    [SerializeField]
    float lookSpeed = 2.0f;
    [SerializeField]
    float lookXLimit = 45.0f;
    [SerializeField] 
    float interactRange = 4.0f;
    
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
            Interact();
    }

    void Interact(){
        if (Input.GetKeyDown(KeyCode.E)){
            CastRay();
        }
    }

    void CastRay(){
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, interactRange);
        if (hit){
            GameObject hitObject = hitInfo.transform.gameObject;
            hitObject.GetComponent<IInteractable>()?.Interact();
        }
    }
}
