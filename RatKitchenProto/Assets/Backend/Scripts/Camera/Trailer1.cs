using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Trailer1 : MonoBehaviour
{
    
    public float duration;
    public GameObject camera;
    
    Quaternion startRotation;
    Quaternion endRotation = Quaternion.Euler(-10, -13.275f, 0);
    
    
    public AnimationCurve curve;

    void Start()
    {
        
        startRotation = camera.transform.rotation;
        StartCoroutine(MoveCamera());
    }

   

    IEnumerator MoveCamera()
    {
        yield return new WaitForSeconds(6);
        CamerasManager.Instance.ShowSecondView();
        
        float timeElapsed = 0;

        while (timeElapsed < duration)
        {
            float t =  timeElapsed / duration;
            
            t = curve.Evaluate(t);
            camera.transform.rotation = Quaternion.Lerp(startRotation, endRotation, t);
            
            timeElapsed += Time.deltaTime;  
            
            yield return null;
        }
        camera.transform.rotation = endRotation;
    }

}
