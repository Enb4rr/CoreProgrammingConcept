using DG.Tweening;
using UnityEngine;

public class Maze : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Ball ball;
    [SerializeField] private Transform ballStartingTransform;

    [Header("Settings")] 
    [SerializeField][Range(0.8f, 5f)] private float duration = 0.8f;
    
    private bool rotating;
    
    /// <summary>
    /// Resets maze
    /// </summary>
    public void ResetMaze()
    {
        // Reset ball position and maze rotation.
        ball.transform.position = ballStartingTransform.position;
        transform.DORotate(Vector3.zero, 0f);
    }
    
    /// <summary>
    /// Rotates the maze to left
    /// </summary>
    public void RotateLeft()
    {
        // Avoid rotating while in movement
        if (rotating) return;
        
        // Rotate using a tween.
        transform.DORotate(new Vector3(0, 0, transform.localEulerAngles.z + 45f), duration)
            .OnStart(() => rotating = true);
        
        // Reset rotating variable.
        DOVirtual.DelayedCall(duration + 0.2f,  () => rotating = false);
    }

    /// <summary>
    /// Rotates the maze to the right
    /// </summary>
    public void RotateRight()
    {
        // Avoid rotating while in movement
        if (rotating) return;
        
        // Rotate using a tween.
        transform.DORotate(new Vector3(0, 0, transform.localEulerAngles.z - 45f), duration)
            .OnStart(() => rotating = true);
        
        // Reset rotating variable.
        DOVirtual.DelayedCall(duration + 0.2f,  () => rotating = false);
    }
}