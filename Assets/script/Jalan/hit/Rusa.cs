using UnityEngine;

public class Rusa : MonoBehaviour
{

    GameManager gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    gm = GameObject.Find("gamemanager").GetComponent<GameManager>(); // ngambil state di gama manager
    //player = GameObject.Find("gamemanager").GetComponent<GameManager>(); // ngambil state di gama manager
        
    }

    void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Player")
        {
            Debug.Log("rusa");
            gm.Status = GameManager.GameState.kalah;
        }
    }
}
