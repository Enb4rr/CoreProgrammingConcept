using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    public UnityEvent winEvent;
    
    /// <summary>
    /// Triggers Unity Event when ball reaches the end
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            winEvent?.Invoke();
        }
    }
}
