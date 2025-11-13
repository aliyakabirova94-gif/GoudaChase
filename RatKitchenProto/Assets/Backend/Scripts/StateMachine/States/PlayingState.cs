using UnityEngine;

public class PlayingState : State
{
    [SerializeField] private S_TimerAndScore TimerAndScore;
    [SerializeField] private KitchenGenerator KitchenGenerator;
    private CameraScript cameraScript;
    private PlayerMovement playerMovement;
    private PlayerChangeLane playerChangeLane;

    private void Awake()
    {
        cameraScript = FindFirstObjectByType<CameraScript>();
        playerMovement = FindFirstObjectByType<PlayerMovement>();
        playerChangeLane = FindFirstObjectByType<PlayerChangeLane>();
    }

    public override void EnterState()
    {

        base.EnterState();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void UpdateState()
    {
        base.UpdateState();

        playerChangeLane.UpdateLaneChange();
        cameraScript.UpdateCamera();
        playerMovement.PlayerUpdate();
        TimerAndScore.UpdateTimer();
        KitchenGenerator.UpdateKitchenGenerator();
    }
}