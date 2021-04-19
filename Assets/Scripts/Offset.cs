using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset : MonoBehaviour
{
    public float offset;
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + offset, transform.position.z);
    }
}
