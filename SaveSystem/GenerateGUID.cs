using UnityEngine;

[ExecuteAlways] //this game object will run in the edittor as well
public class GenerateGUID : MonoBehaviour
{
    [SerializeField]
    private string _gUID = "";

    public string GUID { get => _gUID; set => _gUID = value; }

    private void Awake()
    {
        // Only populate in the editor
        if (!Application.IsPlaying(gameObject))
        {
            // Ensure the object has a guaranteed unique id
            if (_gUID == "")
            {
                //Assign GUID
                _gUID = System.Guid.NewGuid().ToString();
            }
        }
    }
}