using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Animations;
public class GenerateJalur : MonoBehaviour
{
    public GameObject parent;
    public List<GameObject> blokJalan= new List<GameObject>(); 

    
        void OnTriggerEnter(Collider collision)
     {  
         if (collision.gameObject.CompareTag ("Player"))
         {
             Debug.Log("generate");
             Instantiate(blokJalan[Random.Range(0,blokJalan.Count)],new Vector3(0, 0, 700), Quaternion.identity);           
         }
         if (collision.gameObject.CompareTag ("hapus"))
         {
             Debug.Log("Hapus");
             Destroy(parent);
             //parent.SetActive(false);
         }
    }
    
}