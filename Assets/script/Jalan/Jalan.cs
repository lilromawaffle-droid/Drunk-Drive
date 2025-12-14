using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;


public class Jalan : MonoBehaviour
{
    GameManager gm;
    

    void Start()
    {
        gm = FindFirstObjectByType<GameManager>();
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
