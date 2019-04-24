using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotote : MonoBehaviour
{
    public GameObject en;
    
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime*2);
    }
}
