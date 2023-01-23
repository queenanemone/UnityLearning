using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        //부딛힘을 감지했을 때, Console에 출력
        Debug.Log("Crash!");
    }
}
