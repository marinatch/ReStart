
//public class SOGridProperties : MonoBehaviour
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "soGridProperties", menuName = "ScriptableObjects/Grid Properties")]
public class SOGridProperties : ScriptableObject
{
    public SceneName sceneName;
    //The maximum bounds of the tilemap
    public int gridWidth;
    public int gridHeight;
    //The origin points of the tilemap 
    public int originX;
    public int originY;

    [SerializeField]
    public List<GridProperty> gridPropertyList;
}