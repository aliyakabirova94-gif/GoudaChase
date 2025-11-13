using UnityEngine;

public class StartState : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.Instance.SwitchState<PlayingState>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
