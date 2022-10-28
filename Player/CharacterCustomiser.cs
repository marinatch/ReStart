using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomiser : MonoBehaviour
{
    [Header("Hair sprite to chhange")] public SpriteRenderer playerHair;
    [Header("Hair sprites to cycle through")] public List<Sprite> hairOptions = new List<Sprite>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if(currentOption >= hairOptions.Count)
        {
            currentOption = 0;
        }

        playerHair.sprite = hairOptions[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = hairOptions.Count -1;
        }

        playerHair.sprite = hairOptions[currentOption];
    }
}
