using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClickNewGame()
    {
        Debug.Log("�� ����");
    }

    public void OnClickLoad()
    {
        Debug.Log("�ҷ�����");
    }

    public void OnClickOption()
    {
        Debug.Log("�ɼ�");
    }

    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Applicaiont.Quit();
#endif
    }
}
