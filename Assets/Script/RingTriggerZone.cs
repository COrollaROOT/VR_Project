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
            var ring = other.GetComponent<RingRespawner>();
            if (ring != null)
                ring.Respawn();

            // Pole의 점수 가져오기
            var poleScore = GetComponent<PoleScore>();
            int score = poleScore != null ? poleScore.scoreValue : 1; // 기본값 1점

            // 점수 반영
            if (gameManager != null)
                gameManager.OnRingScored(score);
        }
    }
}
