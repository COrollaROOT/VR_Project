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

            // Pole�� ���� ��������
            var poleScore = GetComponent<PoleScore>();
            int score = poleScore != null ? poleScore.scoreValue : 1; // �⺻�� 1��

            // ���� �ݿ�
            if (gameManager != null)
                gameManager.OnRingScored(score);
        }
    }
}
