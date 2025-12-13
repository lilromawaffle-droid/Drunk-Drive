using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Unity.VisualScripting;


public class PLayers : MonoBehaviour
{
    public List<GameObject> spawn= new List<GameObject>(); 

    public int target;
    private Vector3 posisi;
    public float speed;
    private GameManager gm;

    //UI
    //List<GameObject> hit = new List<GameObject>();
    //public int jumlahHit;

    //state
    public enum PlayerState {
        hidup,
        mati,
        skinwalker
    }

    public PlayerState playerstate;

    void Start()
    {
        gm = GameObject.Find("gamemanager").GetComponent<GameManager>(); // ngambil state di gama manager
        target=1;
        playerstate = PlayerState.hidup;
        gm = FindFirstObjectByType<GameManager>();
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

        //switch state

        switch (playerstate)
        {
            case(PlayerState.hidup):
                break;
            case(PlayerState.mati):
                break;
            case(PlayerState.skinwalker):
                break;
        }

    }

    // void OnCollisionEnter(Collision collision)
    // {  
    //     if (collision.gameObject.CompareTag ("generate"))
    //     {
    //         Debug.Log("generate");
    //         Instantiate(blokJalan[Random.Range(0,blokJalan.Count)],new Vector3(0, 0, 700), Quaternion.identity);           
    //     }
    // }
}