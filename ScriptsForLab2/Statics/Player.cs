using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    public static int playerCount = 0;

    void Start()
    {
        playerCount++;
    }
}