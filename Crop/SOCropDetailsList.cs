using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CropDetailsList", menuName = "ScriptableObjects/Crop/Crop Details List")]
public class SOCropDetailsList : ScriptableObject
{
    [SerializeField]
    public List<CropDetails> cropDetails;


    public CropDetails GetCropDetails(int seedItemCode)
    {
        //Find: is a predicates definition. 
        //A predicates definition: is a statement about something that is either true or false.
        //In programming, predicates represent single argument functions that return a boolean value.
        return cropDetails.Find(x => x.seedItemCode == seedItemCode);
    }
}