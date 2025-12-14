using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Animations;
public class GenerateJalur : MonoBehaviour
{
    public GameObject parent;
    public GameManager gm;
    public int contoh;
    public GameObject jalan;
    public Transform mundur;
    
    void Start() {
        
        gm = FindFirstObjectByType<GameManager>();
    }
        void OnTriggerEnter(Collider collision)
     {  
         if (collision.gameObject.CompareTag ("Player"))
         {
            Instantiate (jalan,new Vector3(0,0,700), Quaternion.identity,mundur);
            Instantiate(gm.blokEnemy[0][Random.Range(0,gm.blokEnemy [0].Count)],new Vector3(0, 0, 700), Quaternion.identity,mundur);           
         }
         if (collision.gameObject.CompareTag ("hapus"))
         {
             Debug.Log("Hapus");
             Destroy(parent);
             //parent.SetActive(false);
         }
    }
    
}