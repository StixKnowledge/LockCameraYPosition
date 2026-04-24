using UnityEngine;
using Unity.Cinemachine;

public class LockCameraY : CinemachineExtension
{
    [SerializeField] private float lockedYPosition = 5f;

    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            // Get the position Cinemachine ALREADY calculated (which includes following the player's X)
            Vector3 pos = state.RawPosition;

            // Only overwrite the Y. Leave X and Z exactly as Cinemachine calculated them.
            pos.y = lockedYPosition;

            // Apply it back
            state.RawPosition = pos;
        }
    }
}