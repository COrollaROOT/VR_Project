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
        // �������� (�ӵ� ����)
        rb.velocity *= 0.99f;

        // ȸ�� ���⿡ ���� ���� Ʋ������ ȿ�� �߰� ����
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
            
            Debug.LogWarning("Interactor�� Rigidbody�� �����ϴ�.");
        }
    }
}
