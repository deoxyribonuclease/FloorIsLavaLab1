using UnityEngine;
using System.Collections;

public class Enemy: Humanoid
{
    new public void Yell()
    {
        Debug.Log ("Enemy version of the Yell() method");
    }
}