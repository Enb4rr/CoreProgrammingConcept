using System;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    public UnityEvent winEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            
        }
    }
}
