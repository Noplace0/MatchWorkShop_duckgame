using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "Item name";
    public Sprite icon = null;
    public string description = "Default Item";
    public bool isDefaultItem = false;
    public int stack = 0;
 
    void Start()
    {
        if (isDefaultItem)
        {
            Debug.Log("default item" + name);
        }
    }
    public virtual void Use()
    {
        //use item
        Debug.Log("Using: " + name);
    }

    public virtual void Check()
    {
        Debug.Log("Checking: " + name);

    }
}   
