using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "duck")
        {
            PickUp();
        } else
        {
            Debug.Log(collision.name);
        }
    }

    void PickUp()
    {
        Debug.Log("Picking up: " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);
        if (wasPickedUp)
        {
            Destroy(gameObject);
        }
    }
}
