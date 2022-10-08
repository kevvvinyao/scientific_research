using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

public class Photo : MonoBehaviour
{
    public string str_height;
    public float camera_height;
    public Camera maincamera;
    private bool start = false;
    public int num = 1;
    public string path = "F:\\unityProject\\terrain_save";


    public string front;

    public float MaxHeight = 0;
    public float StepLength;
    
    public int ordnum = 1;

    void GoForwardCaptureCamera()
    {
        SaveHeightData();
        CaptureCamera(maincamera, new Rect(0, 0, Screen.width, Screen.height));
        StepLength = (camera_height - MaxHeight) / 10;
        ordnum ++;
        for (int i = 0; i < 9; i++)
        {
            transform.position += transform.forward * StepLength;
            SaveHeightData();
            CaptureCamera(maincamera, new Rect(0, 0, Screen.width, Screen.height));
            
            ordnum ++;
        }
        ordnum = 1;
        MaxHeight = 0;
    }

    Texture2D CaptureCamera(Camera camera, Rect rect)
    {
        RenderTexture rt = new RenderTexture((int)rect.width, (int)rect.height, -1);
        camera.targetTexture = rt;
        camera.Render();
        RenderTexture.active = rt;

        Texture2D screenShot = new Texture2D(
            (int)rect.width,
            (int)rect.height,
            TextureFormat.RGB24,
            false
        );
        screenShot.ReadPixels(rect, 0, 0);
        screenShot.Apply();

        camera.targetTexture = null;
        RenderTexture.active = null; // JC: added to avoid errors
        GameObject.Destroy(rt);

        byte[] bytes = screenShot.EncodeToJPG();

        
        if (num < 10)
            front = "\\00000";
        else if (num < 100)
            front = "\\0000";
        else
            front = "\\000";

        string colorpath = path + "\\img" + front + num + "_" + ordnum;
        string depthpath = path + "\\depth" + front + num + "_" + ordnum;

        // save color images
        System.IO.File.WriteAllBytes(colorpath + ".jpg", bytes);
        Debug.Log(string.Format("taken an image:{0}", colorpath + ".jpg"));
        // save depth data
        GenerateDepthData(camera, depthpath);
        Debug.Log(string.Format("saved the depth data:{0}", depthpath + ".txt"));

        return screenShot;
    }

    void SaveHeightData()
    {
        StreamWriter recordheight = new StreamWriter(path + "\\camera_height.txt", true);
        camera_height = transform.position.y;
        str_height = camera_height.ToString();

        str_height = num + "_" + ordnum + " " + str_height;
        recordheight.WriteLine(str_height);
        Debug.Log(str_height);
        recordheight.Close();
    }

    // Start is called before the first frame update
    void Start()
    {
        maincamera = GetComponent<Camera>();
        // parameters of camera
        float f = maincamera.focalLength;
        int w = maincamera.pixelWidth;
        int h = maincamera.pixelHeight;
        Debug.Log(string.Format("w:" + w + " h:" + h));
        Vector2 size = maincamera.sensorSize;
        // paramteters inside
        float fx = f * (w / size[0]);
        float fy = f * (h / size[1]);
        float cx = (float)w / 2;
        float cy = (float)h / 2;
        float[,] cameramatrix = new float[3, 3] { { fx, 0, cx }, { 0, fy, cy }, { 0, 0, 1 } };
        // write file
        string filepath = path + "\\cam.txt";
        StreamWriter sw = new StreamWriter(filepath);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sw.Write(cameramatrix[i, j]);
                sw.Write(" ");
            }
            sw.Write("\n");
        }
        sw.Close();
        Debug.Log("Write out parameters inside");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GoForwardCaptureCamera();
            Debug.Log("DONE!");
            num++;
        }
    }

    void GenerateDepthData(Camera camera, string filepath)
    {
        int width = Screen.width;
        int height = Screen.height;
        // int width = (int)rect.width;
        // int height = (int)rect.height;

        StreamWriter sw = new StreamWriter(filepath + ".txt");

        if (ordnum == 1)
        {
            for (int i = height - 1; i >= 0; i--)
            {
                for (int j = 0; j < width; j++)
                {
                    Vector3 pos = new Vector3(j, i, 0);
                    Ray ray = camera.ScreenPointToRay(pos);
                    // Debug.DrawRay(ray.origin, ray.direction * 10, Color.black);
                    RaycastHit hit;
                    // check if hit
                    if (Physics.Raycast(ray, out hit))
                    {
                        Vector3 world_point = camera.WorldToViewportPoint(hit.point);
                        sw.Write(world_point.z);
                        sw.Write("  ");
                        if (world_point.z > MaxHeight) {
                            MaxHeight = Convert.ToSingle(world_point.z);
                        }
                    }
                    // no hit
                    else
                    {
                        Debug.Log("No hit !");
                        sw.Write(-1);
                        sw.Write("  ");
                    }
                }
                sw.Write("\n");
            }
        } else {
            for (int i = height - 1; i >= 0; i--)
            {
                for (int j = 0; j < width; j++)
                {
                    Vector3 pos = new Vector3(j, i, 0);
                    Ray ray = camera.ScreenPointToRay(pos);
                    // Debug.DrawRay(ray.origin, ray.direction * 10, Color.black);
                    RaycastHit hit;
                    // check if hit
                    if (Physics.Raycast(ray, out hit))
                    {
                        Vector3 world_point = camera.WorldToViewportPoint(hit.point);
                        sw.Write(world_point.z);
                        sw.Write("  ");
                    }
                    // no hit
                    else
                    {
                        Debug.Log("No hit !");
                        sw.Write(-1);
                        sw.Write("  ");
                    }
                }
                sw.Write("\n");
            }
        }

        sw.Close();
    }
}
