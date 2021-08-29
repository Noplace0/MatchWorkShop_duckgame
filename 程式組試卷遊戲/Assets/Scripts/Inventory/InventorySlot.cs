using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public GameObject infoslot;
    public Image icon;
    Item item;
    InformationSlot slot;

    private void Start()
    {
        slot = infoslot.GetComponent<InformationSlot>();
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }

    public void CheckItem()
    {
        if (item != null)
        {
            item.Check();
            slot.AddItem(item);
        }
    }
    
    public void UseItem()
    {
       if (item != null)
        {
            item.Use();
            //Inventory.instance.Remove(item);
        }
    }
}
