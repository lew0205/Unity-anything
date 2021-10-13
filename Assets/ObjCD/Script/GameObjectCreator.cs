using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectCreator : MonoBehaviour
{
    void Start()
    {
        GameObject newObject = new GameObject();
        newObject.AddComponent<TestComponent>();
        newObject.name = "Test Component Game Object";
    }

    void Update()
    {
        
    }
}
