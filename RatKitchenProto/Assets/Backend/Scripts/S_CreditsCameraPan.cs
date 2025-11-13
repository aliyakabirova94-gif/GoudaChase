using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class S_CreditsCameraPan : MonoBehaviour
{
    [Header("Dependencies")]
    public GameObject MenuCanvas;
    [Header("Camera Pan Settings")] 
    public Quaternion StartRotation;
    public Quaternion EndRotation;
    public float PanDuration;
    public float PanSpeed;
    
    public void StartCameraPan()
    {
        StartRotation = transform.rotation;
        transform.rotation = Quaternion.Lerp(StartRotation, EndRotation, PanSpeed * Time.deltaTime / PanDuration);
        MenuCanvas.SetActive(false);
    }

    public void ReturnCameraPan()
    {
        transform.rotation = Quaternion.Lerp(EndRotation, StartRotation, PanSpeed * Time.deltaTime / PanDuration);
        MenuCanvas.SetActive(true);
    }
}
