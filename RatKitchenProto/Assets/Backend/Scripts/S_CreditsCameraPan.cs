using UnityEngine;


public class S_CreditsCameraPan : MonoBehaviour
{
    [Header("Dependencies")]
    public GameObject MenuCanvas;
    public GameObject returnButton;
    [Header("Camera Pan Settings")]

    public GameObject CameraPanTarget;
    public GameObject mainCamera;
    public float PanDuration;
    public float PanSpeed;



    public void StartCameraPan()
    {
        MenuCanvas.SetActive(false);
        mainCamera.SetActive(false);
        CameraPanTarget.SetActive(true);
        returnButton.SetActive(true);
    }

    public void ReturnCameraPan()
    {
        mainCamera.SetActive(true);
        MenuCanvas.SetActive(true);
        CameraPanTarget.SetActive(false);
        returnButton.SetActive(false);
    }
}
