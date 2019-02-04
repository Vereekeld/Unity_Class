using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Rotate_2 : MonoBehaviour
{
    public float speed = 1.0f;
    Vector3 OA = new Vector3(101, 0, -5);
    Vector3 OB = new Vector3(119, 0,-5);

    private void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        transform.position = Vector3.Lerp(OA, OB, Mathf.PingPong(Time.time, 1));
    }
}
