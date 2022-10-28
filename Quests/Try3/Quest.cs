using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Quest : MonoBehaviour
{
    public List<Goal> Goals { get; set; } = new List<Goal>();
    public string QuestName { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }

    public GameObject itemReward;
    [SerializeField] private float x, y;

    public void CheckGoals()
    {
        Completed = Goals.All(goal => goal.Completed);
        if (Completed) GiveReward();
    }

    void GiveReward()
    {
        var position = new Vector3(x, y);
        GameObject gameObject =  Instantiate(itemReward, position, Quaternion.identity);

    }


}
