using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

        #region Singleton
                               

    public static Inventory instance;

    public List<Item> items = new List<Item>();


    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Extra Inventory");
            return;
        }

        instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    public int space = 6;
    public bool Add (Item item)
    {
        {
            //add stacking
            if (items.Count >= space)
            {
                Debug.Log("Not enough space");
                return false;
            }
            //check if we have existing item in our inventory
            // if yes stack it,
            // if no add it as a new item
            //print("add item");
            items.Add(item);
            if (onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }
        }
        //default
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }

    public void resetItems()
    {
        print("Resetting items count: " + items.Count);
        items.Clear();
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}
