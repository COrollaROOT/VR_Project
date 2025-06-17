using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingResetZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ring"))
        {
            RingRespawner ring = other.GetComponent<RingRespawner>();
            if (ring != null)
            {
                ring.Respawn();
            }
        }
    }
}
