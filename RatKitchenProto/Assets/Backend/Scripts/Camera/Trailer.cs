using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Trailer : MonoBehaviour
{
    
    float startSize = 5.63f;
    float endSize = 3.32f;
    float cameraSize;
    

    void Start()
    {
        StartCoroutine(MoveCamera());
    }

    IEnumerator MoveCamera()
    {
        cameraSize = Mathf.Lerp(startSize, endSize, 1);
        yield return new WaitForSeconds(3);
    }

}
