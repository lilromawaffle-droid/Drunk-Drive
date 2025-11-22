using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PLayer : MonoBehaviour
{
    public List<GameObject> spawn= new List<GameObject>(); 

    public int target;
    private Vector3 posisi;
    public float speed;

    //UI
    List<GameObject> hit = new List<GameObject>();
    public int jumlahHit;

    void Start()
    {
        target=1;
    }

    void Update()
    {
        // input 
        if (Input.GetKeyDown(KeyCode.A))
        {
            target--;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            target++;
        }

        // batasi target
        if (target < 0) target = 0;
        if (target > spawn.Count - 1) target = spawn.Count - 1; //gak lebih dari 2

        // te kapikiran ie mah
        posisi = spawn[target].transform.position;

        transform.position = Vector3.MoveTowards(transform.position,posisi,speed * Time.deltaTime);//cuma bisa dipake kalau dipanggil tiap frame (gak di dalem if)

    }
}