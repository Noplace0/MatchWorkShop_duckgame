using UnityEngine;

public class InformationUI : MonoBehaviour
{
    public Transform itemsParent;
    public GameObject informationUI;
    Inventory inventory;
    InformationSlot[] slots;
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InformationSlot>();
    }

    public void OpenUI()
    {
        informationUI.SetActive(true);
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
