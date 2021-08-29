using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    public GameObject inventoryUI;
    public GameObject informationUI;
    Inventory inventory;
    InventorySlot[] slots;
    // Start is called before the first frame update
    void Awake()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HandleUI()
    {
        //if player click the backpack
        inventoryUI.SetActive(!inventoryUI.activeSelf);
        informationUI.SetActive(false);
    }
    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            } else{
                slots[i].ClearSlot();
            }
        }
    }
}
