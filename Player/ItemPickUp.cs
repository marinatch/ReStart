using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    { //If the player collides with an Item, then this Item will have the Item component on it. This is how it will be detected
        Item item = collision.GetComponent<Item>();

        if (item != null)
        {
            // Get item details from the InventoryManager
            ItemDetails itemDetails = InventoryManager.Instance.GetItemDetails(item.ItemCode);

            // if item can be picked up
            if (itemDetails.canBePickedUp == true)
            {
                // Add item to inventory
                InventoryManager.Instance.AddItem(InventoryLocation.player, item, collision.gameObject);

                // Play pick up sound
                AudioManager.Instance.PlaySound(SoundName.effectPickupSound);

            }
        }
    }
}