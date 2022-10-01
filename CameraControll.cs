using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public float velocity = 2.0f;
    float _rotationX;
    float rotationY;
    public float rotsensityY = 5.0f;
    public float rotsensityX = 5.0f;
    public float minimumVert = -90.0f;
    public float maximumVert = 90.0f; //是否可以控制旋转 public bool CanControl = false;

    float posX;
    float posY;

    public float PossensitivitX = 1.0f;
    public float PossensitivitY = 1.0f;

    // 点击鼠标右键旋转摄像头 
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

    // 键盘控制相机移动
    void myKeyboard()
    {
        if (Input.GetKey(KeyCode.W)) // 向前 UpArrow z

            transform.position += transform.forward * velocity;

        if (Input.GetKey(KeyCode.S)) // 向后 DownArrow

            transform.position += -transform.forward * velocity;

        if (Input.GetKey(KeyCode.A)) // 向左 LeftArrow x

            transform.position += -transform.right * velocity;

        if (Input.GetKey(KeyCode.D)) // 向右 RightArrow

            transform.position += transform.right * velocity;

        if (Input.GetKey(KeyCode.UpArrow)) // 向上 y

            transform.position += transform.up * velocity;

        if (Input.GetKey(KeyCode.DownArrow)) // 向下

            transform.position += -transform.up * velocity;
    }

    // Update is called once per frame
    void Update()
    {
        CameraRot();
        myKeyboard();
    }
}
