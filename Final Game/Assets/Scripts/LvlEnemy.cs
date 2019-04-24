using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlEnemy : MonoBehaviour
{
    Vector2 A = new Vector2(1011.8f, 23f);
    Vector2 B = new Vector2(1028.7f, 23f);

    void Update()
    {
        transform.position = Vector2.Lerp(A, B, Mathf.PingPong(Time.time / 2, 1));
    }
}
