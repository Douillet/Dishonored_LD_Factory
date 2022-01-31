using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraUI : MonoBehaviour
{
    Camera camUI;

    // Set Camera UI
    void Start()
    {
        camUI = GameObject.Find("Camera_UI").GetComponent<Camera>();
        GetComponent<Canvas>().worldCamera = camUI;
    }
}
