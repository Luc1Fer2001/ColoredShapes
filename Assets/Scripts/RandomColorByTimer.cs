using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class RandomColorByTimer : MonoBehaviour
{
    private Timer timer;
    private Material material;
    private GeometryObjectModel geometryObjectModel;
    public Timer PublicTimer => timer;
    void Awake()
    {
        material = GetComponent<Renderer>().material;
        timer = new Timer(GetGameData.Instance.ObservableTime, SetColor);
        geometryObjectModel = GetComponent<GeometryObjectModel>();
    }

    private void Start()
    {
        timer.Restart();
    }

    private void SetColor()
    {
        material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        geometryObjectModel.geometryColor = material.color;
        timer.Restart();
    }
}
