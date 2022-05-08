using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionController : MonoBehaviour
{
    public string targetTag;
    public UnityEvent triggerAction;

    void OnTriggerEnter (Collider other)
    {
        if ( other.gameObject.tag == targetTag )
        {
            Debug.Log("Touch with " + other.gameObject.name);
            triggerAction?.Invoke();
        }
        
    }
}
