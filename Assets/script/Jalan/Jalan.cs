using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;


public class Jalan : MonoBehaviour
{
    GameManager gm;
    ProgresBar pg;
    public float delay;
    
    public List<GameObject> spawn1 = new List<GameObject>();
    public List<GameObject> spawn2 = new List<GameObject>();
    public List<GameObject> spawn3 = new List<GameObject>();
    public List<GameObject> spawn4 = new List<GameObject>();
    public List<GameObject> spawn5 = new List<GameObject>();

    void Start()
    {
        gm = FindFirstObjectByType<GameManager>();
        Instantiate(gm.listEnemy[Random.Range(0,1)],new Vector3(0,0,0),Quaternion.identity);
    }



    void Update()
    {   
        //pg.setProgres(currenttWaktu);        
         if (gm.currenttWaktu >= 200)//menang
         {
            Debug.Log ("Menang");
            gm.Status = GameManager.GameState.menang;
            gm.speed=0; 
         }
         else
         {
            transform.position -= new Vector3(0,0,gm.speed*Time.deltaTime);            
         }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("hapus"))
        {
            Debug.Log("hapus");
            this.gameObject.SetActive(false);
        }
    }


}
