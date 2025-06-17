using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    public void ExitGame()
    {
        // ����� ������ �� ����
        Application.Quit();

#if UNITY_EDITOR
        // �����Ϳ��� �׽�Ʈ�� ���� �� �ڵ�� Play ��� ����
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
