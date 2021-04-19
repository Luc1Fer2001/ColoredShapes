using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryRename : MonoBehaviour
{
    private ClickColorGetData clickColorGetData;
    [SerializeField]
    private JsonReader jsonReader;
    private string type;

    private void Start()
    {
        jsonReader = JsonSinglton.Instance.GetComponent<JsonReader>();
        clickColorGetData = GetComponent<ClickColorGetData>();
        type = clickColorGetData.ClickColor.objectType;
        for (int i = 0; i < jsonReader.shapeList.shape.Length; i++)
        {
            if(type == jsonReader.shapeList.shape[i].type)
            {
                gameObject.name = jsonReader.shapeList.shape[i].name;
            }
        }
    }
}
