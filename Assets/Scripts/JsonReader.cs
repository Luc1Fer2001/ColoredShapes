using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    [SerializeField]
    private TextAsset shapesName;

    [System.Serializable]
    public class Shape
    {
        public string name;
        public string type;
    }

    [System.Serializable]
    public class ShapeList
    {
        public Shape[] shape;
    }

    public ShapeList shapeList = new ShapeList();
    void Start()
    {
        shapeList = JsonUtility.FromJson<ShapeList>(shapesName.text);
    }
}
