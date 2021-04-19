using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameData/GeometryObjectData", fileName = "NewGeometryObjectData")]
public class GeometryObjectData : ScriptableObject
{
    public List<ClickColorData> clicksData;
}
