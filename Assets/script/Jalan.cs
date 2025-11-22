using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class Jalan : MonoBehaviour
{
    GameManager gm;
    public float speed;
    public float waktu;

    void Start()
    {
        speed=100f;
        StartCoroutine(Nambah());

    }

    IEnumerator Nambah()
    {
        while (true)
        {
            waktu += 0.1f;

            if (waktu <= 5f)
            {   
                speed += 1f;
                Debug.Log("0.5");
            }
            else if (waktu <= 10f)
            {
                speed += 2f;
                Debug.Log("2");
            }
            else if (waktu <=15)
            {
                speed += 3f;
                Debug.Log("3");
            }
            else
            {
                speed += 4f;
                Debug.Log("4");
            }
                

            yield return new WaitForSeconds(0.1f);
        }
        

    }
    void Update()
    {
        
        if (waktu >= 20f)//menang
        {
            gm.Status = GameManager.GameState.menang;
        }
        else
        {
            transform.position -= new Vector3(0,0,speed*Time.deltaTime);            
        }
        
    }

}
