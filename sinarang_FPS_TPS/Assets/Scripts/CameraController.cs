using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{   
    public Camera FPC;
    public Camera TPC;

    // Start is called before the first frame update
    void Start()
    {
        mainCameraOn();
    }

    void mainCameraOn()
    {
        TPC.enabled = true;
        FPC.enabled = false;
    }

    void switchCameraOn()
    {
        TPC.enabled = !TPC.enabled;
        FPC.enabled = !FPC.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            switchCameraOn();
        }
    }
}
