using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    Vector2 A = new Vector2(13.6f, 3f);
    Vector2 B = new Vector2(-4f, 3f);

    void Update()
    {
        transform.position = Vector2.Lerp(A, B, Mathf.PingPong(Time.time / 4, 1));
    }
}
