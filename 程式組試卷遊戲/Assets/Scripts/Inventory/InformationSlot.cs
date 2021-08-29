using UnityEngine;
using UnityEngine.UI;

public class InformationSlot : MonoBehaviour
{
    public GameObject informationUI;
    public Image icon;
    public Text title;
    public Text description;
    Item item;

    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        title.text = item.name;
        description.text = item.description;
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
            //Inventory.instance.Remove(item);
            //Debug.Log("clicked checkitem"+ item.name);
            //AddItem(item);
        }
    }
    
    public void UseItem()
    {
       if (item != null)
        {
            item.Use();
            Inventory.instance.Remove(item);
            informationUI.SetActive(false);
        }
    }
}
