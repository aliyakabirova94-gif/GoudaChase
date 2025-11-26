using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Trailer : MonoBehaviour
{
    public float lerpedValue;
    public float duration;
    float startSize = 5.63f;
    float endSize = 3.32f;
    
    public AnimationCurve curve;

    void Start()
    {
        CamerasManager.Instance.ShowFirstView();
        StartCoroutine(MoveCamera());
    }

    void Update()
    {
        
    }

    IEnumerator MoveCamera()
    {
        float timeElapsed = 0;

        while (timeElapsed < duration)
        {
            float t =  timeElapsed / duration;
            
            t = curve.Evaluate(t);
            lerpedValue = Mathf.Lerp(startSize, endSize, t);
            Camera.main.orthographicSize = lerpedValue;
            timeElapsed += Time.deltaTime;
            
            yield return null;
        }
        lerpedValue = endSize;
    }

}
