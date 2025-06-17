using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    public void ExitGame()
    {
        // 빌드된 상태일 때 종료
        Application.Quit();

#if UNITY_EDITOR
        // 에디터에서 테스트할 때는 이 코드로 Play 모드 종료
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
