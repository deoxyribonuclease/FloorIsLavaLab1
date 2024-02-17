using UnityEngine;
using System.Collections;

public class SomeOtherClass : MonoBehaviour 
{
    void Start () 
    {
        SomeClass myClass = new SomeClass();

        myClass.GenericMethod<int>(5);
    }
}