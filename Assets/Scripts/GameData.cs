using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameData/GameData", fileName = "NewGameData")]
public class GameData : ScriptableObject
{
    [SerializeField]
    private int observableTime;
    public int ObservableTime => observableTime;
}