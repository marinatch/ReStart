using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "so_SceneSoundsList", menuName = "ScriptableObjects/Sounds/Scene Sounds List")]
public class SOSceneSoundsList : ScriptableObject
{
    [SerializeField]
    public List<SceneSoundsItem> sceneSoundsDetails;
}
