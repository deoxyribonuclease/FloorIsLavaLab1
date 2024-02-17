using UnityEngine;
using System.Collections;

public class Orc : Enemy
{
    new public void Yell()
    {
        Debug.Log ("Orc version of the Yell() method");
    }
}
