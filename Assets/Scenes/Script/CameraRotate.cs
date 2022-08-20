using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{


    public GameObject refObject; // referensi object yang akan dipilih untuk rotate
    private Vector3 startingPosition; // posisi mouse saat memulai pergeseran object 
    private Vector3 currentPosition; // posisi mouse saat mendrag
    private Vector3 diffposition; // selisih posisi pada current dan start

    private Vector3 currentRotation; // menahan posisi object saat object di rotate


    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startingPosition = Input.mousePosition;
            currentRotation = new Vector3 (refObject.transform.rotation.eulerAngles.x, 0, refObject.transform.rotation.eulerAngles.z);
            Debug.Log(" Mouse click mouse position " + Input.mousePosition);

        }
        else if (Input.GetMouseButton(0))
        {
            currentPosition = Input.mousePosition;
            diffposition = currentPosition - startingPosition;
            float xRotation = currentRotation.x + diffposition.y / 2;
            float zRotation = currentRotation.z - diffposition.x / 2;
            refObject.transform.rotation = Quaternion.Euler(xRotation, 0, zRotation);
            Debug.Log(" Mouse drag mouse position " + Input.mousePosition + " difference : "+diffposition);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log(" Mouse release mouse position " + Input.mousePosition);
        }
    }
}
