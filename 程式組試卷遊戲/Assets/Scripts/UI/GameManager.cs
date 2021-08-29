using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject messagePanel;
    public GameObject duck;
    public Transform startLocation;
    public GameObject mapItem;
    public GameObject inventoryUI;

    float playerspeed;
    Player player;
    Inventory inv;
    GameObject[] lastGameItems;


    // Start is called before the first frame update
    void Start()
    {
        //messagePanel.SetActive(false);
        player = duck.GetComponent<Player>();
        inv = GetComponent<Inventory>();
    }

    public void askRestart()
    {
        messagePanel.SetActive(true);
        playerspeed = player.Speed;
        player.Speed = 0;
    }

    public void Restart()
    {
        //Back To Start Point
        duck.transform.position = startLocation.position;
        //Reset items
        inv.resetItems();
        //Give Start item
        GetComponent<StartItem>().giveDefaultItem();
        //Restart the game
        messagePanel.SetActive(false);
        //Reset speed
        player.Speed = playerspeed;
        //Spawn Item
        resetMapItem();
        inventoryUI.SetActive(false);
    }

    public void resetMapItem()
    {
        //remove last game map item
        lastGameItems = GameObject.FindGameObjectsWithTag("MapItem");
        foreach (GameObject lastGameItem in lastGameItems)
        {
            Destroy(lastGameItem);
        }
        Instantiate(mapItem, mapItem.transform.position, Quaternion.identity);
    }
    public void Cancel()
    {
        messagePanel.SetActive(false);
        player.Speed = playerspeed;
    }
}
