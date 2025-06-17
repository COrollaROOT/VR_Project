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
            // 링이 통과했을 때만 점수 올리기
            gameManager.OnRingScored();
        }
    }
}
