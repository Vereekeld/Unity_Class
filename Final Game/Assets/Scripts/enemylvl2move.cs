using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemylvl2move : MonoBehaviour
{
    Vector2 A = new Vector2(1118f, 25.5f);
    Vector2 B = new Vector2(1101.7f, 25.5f);

    void Update()
    {
        transform.position = Vector2.Lerp(A, B, Mathf.PingPong(Time.time / 2, 1));
    }
}
