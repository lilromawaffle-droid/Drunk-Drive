using Unity.VisualScripting;
using UnityEngine;

public class Anomali : MonoBehaviour
{
    GameManager gm;
    void Start()
    {
        gm = GameObject.Find("gamemanager").GetComponent<GameManager>(); // ngambil state di gama manager

    }

        void OnTriggerEnter(Collider collision)
    {
       if (collision.gameObject.tag == "Player")
        {
            Debug.Log("rusa");
            gm.Status = GameManager.GameState.kalah;
            this.gameObject.SetActive(false);
            gm.hit++;
        }
       if (collision.gameObject.tag == "gerak")
        {
            
        }
    }
}
