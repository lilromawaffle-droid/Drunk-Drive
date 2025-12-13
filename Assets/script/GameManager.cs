using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using Unity.Collections;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{
    PLayers p;
    Jalan j;
    public enum GameState
    {
        maju,
        menang,
        kalah
    }
    public GameState Status;
    
    public enum Stages
    {
        pertama,
        kedua,
        ketiga
    }
    public Stages stage;
    public int hit;
    public float speed;
    public int currenttWaktu;

    public List<GameObject> listEnemy = new List<GameObject>();
    public List<GameObject> listDeer = new List<GameObject>();

    void Start()
    {
        //speed jalan
        currenttWaktu=0;
        StartCoroutine(Nambah());

        hit = 0;

        p = GameObject.Find("player").GetComponent<PLayers>(); // ngambil state di gama manager
        
        Status= GameState.maju;
    }

    void Update()
    {
        if (hit >5)hit = 5;

        switch (Status)
        {
            case(GameState.maju):
                break;
            case(GameState.menang):
                //buat animasi


                //panel_menang.setActive(true)
                p.playerstate = PLayers.PlayerState.mati;
                break;
            case(GameState.kalah):
                p.playerstate = PLayers.PlayerState.mati;
                break;
        }        
    
/*
        switch (stage)
        {
            case(Stages.pertama):
                j.delay = 5f;
                break;
            case(Stages.kedua):
                j.delay = 3f;
                break;
            case(Stages.ketiga):
                j.delay = 2f;
                break;
        }        */
    }

    IEnumerator Nambah()
    {
        while (true) //kecepatan maju
        {
            currenttWaktu += 1;

            if (currenttWaktu <= 5f)
            {   
                speed += 2f;
                //Debug.Log("0.5");
            }
            else if (currenttWaktu <= 10f)
            {
                speed += 4f;
                //Debug.Log("2");
            }
            else if (currenttWaktu <=15)
            {
                speed += 8f;
               // Debug.Log("3");
            }
            else
            {
                speed += 16f;
                //Debug.Log("4");
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}