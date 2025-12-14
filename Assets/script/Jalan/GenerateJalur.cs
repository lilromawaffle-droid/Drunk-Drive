using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Animations;
public class GenerateJalur : MonoBehaviour
{
    public GameObject parent;
    public GameManager gm;
    public int contoh;

    void Start() {
        gm = FindFirstObjectByType<GameManager>();
    }
        void OnTriggerEnter(Collider collision)
     {  
         if (collision.gameObject.CompareTag ("Player"))
         {
            Debug.Log("generate");
            Instantiate(gm.blokJalan[0][Random.Range(0,gm.blokJalan[0].Count)],new Vector3(0, 0, 700), Quaternion.identity);           
         }
         if (collision.gameObject.CompareTag ("hapus"))
         {
             Debug.Log("Hapus");
             Destroy(parent);
             //parent.SetActive(false);
         }
    }
    
}