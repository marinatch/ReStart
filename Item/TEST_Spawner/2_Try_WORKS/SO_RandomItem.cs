using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "so_RandomItem", menuName = "ScriptableObjects/Item/Random Items List")]
public class SO_RandomItem : ScriptableObject
{
    [SerializeField]
    public List<RandomItemDetails> randomItemDetails;
}
