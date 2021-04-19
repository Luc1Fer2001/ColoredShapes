using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameData/ClickColorData", fileName = "NewClickColorData")]
public class ClickColorData : ScriptableObject
{
    public string objectType;
    public int minClicksCount;
    public int maxClicksCount;
    public Color color;
}
