using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PortalManager : MonoBehaviour
{
    public UnityEvent inEventTrigger;

    private void OnTriggerEnter(Collider other)
    {
        inEventTrigger.Invoke();
    }
}
