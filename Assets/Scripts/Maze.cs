using DG.Tweening;
using UnityEngine;

public class Maze : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Ball ball;
    [SerializeField] private Transform ballStartingTransform;

    [Header("Settings")] 
    [SerializeField] private float duration = 0.5f;
    
    private bool rotating;
    
    public void ResetMaze()
    {
        ball.transform.position = ballStartingTransform.position;
        transform.DORotate(Vector3.zero, 0f);
    }
    
    public void RotateLeft()
    {
        if (rotating) return;
        
        transform.DORotate(new Vector3(0, 0, transform.localEulerAngles.z + 45f), duration)
            .OnStart(() => rotating = true);
        
        DOVirtual.DelayedCall(duration + 0.2f,  () => rotating = false);
    }

    public void RotateRight()
    {
        if (rotating) return;
        transform.DORotate(new Vector3(0, 0, transform.localEulerAngles.z - 45f), duration)
            .OnStart(() => rotating = true);
        
        DOVirtual.DelayedCall(duration + 0.2f,  () => rotating = false);
    }
}