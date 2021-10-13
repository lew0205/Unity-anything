using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputTester : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Down");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Hold");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Up");
        }
      //  Debug.Log(Input.mousePosition);

        float value = Input.GetAxis("Mouse ScrollWheel");

        Vector2 scrollDelta = Input.mouseScrollDelta;

        if (scrollDelta.y>0)
        {
            Debug.Log("위로 돌림 : " + scrollDelta.y);
        }

        if (scrollDelta.y < 0)
        {
            Debug.Log("아래로 돌림 : " + scrollDelta.y);
        }
    }
}
