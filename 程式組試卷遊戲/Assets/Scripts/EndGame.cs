using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject game;
    GameManager manager;


    private void Start()
    {
        manager = game.GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "duck")
        {
            Debug.Log(collision.name);
            manager.askRestart();
        } else
        {
            Debug.Log(collision.name);
        }
    }
}
