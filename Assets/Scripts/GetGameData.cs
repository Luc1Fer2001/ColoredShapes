using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGameData : MonoBehaviour
{
    private static GetGameData instance;
    public static GetGameData Instance => instance;
    [SerializeField]
    private GameData gameData;
    private float observableTime;
    public float ObservableTime => observableTime;

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
        observableTime = gameData.ObservableTime;
    }
}
