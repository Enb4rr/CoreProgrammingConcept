using DG.Tweening;
using UnityEngine;

public class Maze : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Ball equippedBall;
    [SerializeField] private Transform ballStartingTransform;

    [Header("Settings")] 
    [SerializeField] private float duration = 0.2f;
    
    GameObject ball;
    private bool rotating;

    public void UpdateEquippedBall(Ball newBall)
    {
        equippedBall = newBall;
        ResetMaze();
    }
    
    public void ResetMaze()
    {
        if (ball != null) Destroy(ball);
        ball = Instantiate(equippedBall.gameObject, ballStartingTransform);
        transform.rotation = Quaternion.identity;
    }
    
    public void RotateLeft()
    {
        if (rotating) return;
        
        transform.DORotate(new Vector3(0, 0, transform.localEulerAngles.z + 90f), duration)
            .OnStart(() => rotating = true);
        
        DOVirtual.DelayedCall(0.3f,  () => rotating = false);
    }

    public void RotateRight()
    {
        if (rotating) return;
        transform.DORotate(new Vector3(0, 0, transform.localEulerAngles.z - 90f), duration)
            .OnStart(() => rotating = true);
        
        DOVirtual.DelayedCall(0.3f,  () => rotating = false);
    }
}