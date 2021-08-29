using UnityEngine;

public class StartItem : MonoBehaviour
{
    public Item[] startItem;
    public void Start()
    {
        giveDefaultItem();
    }

    public void giveDefaultItem()
    {
        foreach (Item i in startItem)
        {
            if (i.isDefaultItem)
            {
                Debug.Log("Start item: " + i.name);
                Inventory.instance.Add(i);

            }
        }
    }
}
