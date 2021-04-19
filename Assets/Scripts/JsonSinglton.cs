using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonSinglton : MonoBehaviour
{
    private static JsonSinglton instance;
    public static JsonSinglton Instance => instance;

    private void Awake()
    {
        if (Instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError(gameObject);
        }
    }
}
