using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // Invoke the event(Run all events in 'onEnter')
            onEnter.Invoke();
        }
    }
}
