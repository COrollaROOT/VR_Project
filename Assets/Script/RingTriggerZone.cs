using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingTriggerZone : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ring"))
        {
            // ���� ������� ���� ���� �ø���
            gameManager.OnRingScored();
        }
    }
}
