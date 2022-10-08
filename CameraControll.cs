using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CameraControll : MonoBehaviour
{
    public float velocity = 2.0f;
    float _rotationX;
    float rotationY;
    public float rotsensityY = 5.0f;
    public float rotsensityX = 5.0f;
    public float minimumVert = -90.0f;
    public float maximumVert = 90.0f;
     // public bool CanControl = false;

    
    public string str_height;

    float posX;
    float posY;

    public float PossensitivitX = 1.0f;
    public float PossensitivitY = 1.0f;

    
    void CameraRot()
    {
        if (Input.GetMouseButton(1))
        {
            rotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * rotsensityY;
            _rotationX -= Input.GetAxis("Mouse Y") * rotsensityX;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
    }


    void myKeyboard()
    {
        if (Input.GetKey(KeyCode.W)) // UpArrow z

            transform.position += transform.forward * velocity;

        if (Input.GetKey(KeyCode.S)) // DownArrow

            transform.position += -transform.forward * velocity;

        if (Input.GetKey(KeyCode.A)) // LeftArrow x

            transform.position += -transform.right * velocity;

        if (Input.GetKey(KeyCode.D)) // RightArrow

            transform.position += transform.right * velocity;

        if (Input.GetKey(KeyCode.UpArrow)) // y

            transform.position += transform.up * velocity;

        if (Input.GetKey(KeyCode.DownArrow)) 

            transform.position += -transform.up * velocity;
        
        // if (Input.GetKey(KeyCode.Q)) {

            //Debug.Log(transform.position.y);
            // camera_height = transform.position.y;
            // System.IO.File.WriteAllText("/Users/kevinyao/camera_height.txt", transform.position.y);

            // StreamWriter recordheight = new StreamWriter("F:\\unityProject\\camera_height.txt", true);
            // str_height = transform.position.y.ToString();
            // recordheight.WriteLine(str_height);
            // Debug.Log(str_height);
            // recordheight.Close();
        // }
    }

    // Update is called once per frame
    void Update()
    {
        CameraRot();
        myKeyboard();
    }
}
