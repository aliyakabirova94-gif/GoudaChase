using UnityEngine;

public class CamerasManager : MonoBehaviour
{
    public static CamerasManager Instance;
    void Awake()
    {
        Instance = this;
    }
    public Camera firstCamera;
    public Camera secondCamera;

    
    public void ShowFirstView() {
        firstCamera.enabled = false;
        secondCamera.enabled = true;
    }
    
    
    public void ShowSecondView() {
        firstCamera.enabled = true;
        secondCamera.enabled = false;
    }
}
