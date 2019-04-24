using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceEn : MonoBehaviour
{
    Vector2 A = new Vector2(1192.6f, -7.8f);
    Vector2 B = new Vector2(1018.7f, -7.8f);

    void Update()
    {
        transform.position = Vector2.Lerp(A, B, Mathf.PingPong(Time.time / 2, 1));
    }
}
