using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "so_SoundList", menuName = "ScriptableObjects/Sounds/Sound List")]
public class SOSoundList : ScriptableObject
{
    [SerializeField]
    public List<SoundItem> soundDetails;

}
