using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGoal : Goal
{

	[SerializeField] private UIInventorySlot[] inventorySlot = null;

	public DestroyGoal(int goalItemId, string description, bool completed, int currentAmount, int requiredAmount)
	{
		this.GoalItemId = goalItemId;
		this.Description = description;
		this.Completed = completed;
		this.CurrentAmount = currentAmount;
		this.RequiredAmount = requiredAmount;
	}

	/*
	public override void Init()
	{
		base.Init();
		//look for Item destroyed event or make one
		//Events.OnItemDestroyed += ItemDestroyed;
		EventHandler.DestroyCropPrefabsEvent += CropDestroyed;
	}

	public void CropDestroyed(Crop crop)
	{
		if (crop.CropId == this.GoalCropId)
{
			this.CurrentAmount++;
			Evaluate();
		}
	}
	*/

	public int GoalItemId { get; set; }
	public GameObject cropToCollect;
	private int collected;

	public void ItemCollected(InventoryLocation inventoryLocation, List<InventoryItem> inventoryList)
	{
		if (inventoryLocation == InventoryLocation.player)
		{
			if (inventorySlot.Length > 0 && inventoryList.Count > 0)
			{
				// loop through inventory slots and update with corresponding inventory list item
				for (int i = 0; i < inventorySlot.Length; i++)
				{
					if (i < inventoryList.Count)
					{
						int itemCode = inventoryList[i].itemCode;

						ItemDetails itemDetails = InventoryManager.Instance.GetItemDetails(itemCode);

						if (itemDetails != null)
						{
							inventorySlot[i].itemQuantity = inventoryList[i].itemQuantity;
							if (inventorySlot[i].itemDetails.itemCode == this.GoalItemId)
							{
								this.CurrentAmount++;
								Evaluate();
							}

						}
					}
					else
					{
						break;
					}
				}
			}
		}
	}

	public int CountCollectedItems()
    {
		//EventHandler.CallDestroyCropPrefabsEvent += CropDestroyed;
		EventHandler.InventoryUpdatedEvent += ItemCollected;
		return collected;
    }

}

