using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ThrowAssist : MonoBehaviour
{
    private XRGrabInteractable grab;
    private Rigidbody rb;

    void Awake()
    {
        grab = GetComponent<XRGrabInteractable>();
        rb = GetComponent<Rigidbody>();

        grab.selectExited.AddListener(OnRelease);
    }

    void FixedUpdate()
    {
        // 공기저항 (속도 감소)
        rb.velocity *= 0.99f;

        // 회전 방향에 따라 방향 틀어지는 효과 추가 가능
    }



    void OnRelease(SelectExitEventArgs args)
    {
        var interactor = args.interactorObject.transform;
        Rigidbody interactorRb = interactor.GetComponent<Rigidbody>();

        if (interactorRb != null)
        {
            rb.velocity = interactorRb.velocity * 1.2f;
            rb.angularVelocity = interactorRb.angularVelocity;
        }
        else
        {
            
            Debug.LogWarning("Interactor에 Rigidbody가 없습니다.");
        }
    }
}
