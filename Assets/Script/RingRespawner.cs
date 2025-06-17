using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRespawner : MonoBehaviour
{
    private Vector3 startPos;

    void Start() => startPos = transform.position;

    public void Respawn()
    {
        transform.position = startPos;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
