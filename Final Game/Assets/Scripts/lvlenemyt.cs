using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlenemyt : MonoBehaviour
{
    Vector2 A = new Vector2(1056.8f, 37.9f);
    Vector2 B = new Vector2(1068.7f, 37.9f);

    void Update()
    {
        transform.position = Vector2.Lerp(A, B, Mathf.PingPong(Time.time / 2, 1));
    }
}
