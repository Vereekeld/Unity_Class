using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy4 : MonoBehaviour
{
    Vector2 A = new Vector2(62.3f, 23.5f);
    Vector2 B = new Vector2(74.1f, 23.5f);

    void Update()
    {
        transform.position = Vector2.Lerp(A, B, Mathf.PingPong(Time.time / 2, 1));
    }
}
