using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceEnT : MonoBehaviour
{
    Vector2 A = new Vector2(1045.9f, 9.2f);
    Vector2 B = new Vector2(1126.37f, 9.2f);

    void Update()
    {
        transform.position = Vector2.Lerp(A, B, Mathf.PingPong(Time.time / 2, 1));
    }
}
