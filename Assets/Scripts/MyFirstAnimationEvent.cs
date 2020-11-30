using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstAnimationEvent : MonoBehaviour
{

    public void MyFirstEventFunction(int s)
    {
        Debug.Log(s);
    }
    public void MyFirstEventFunction(string s)
    {
        Debug.Log(s);
    }
}
