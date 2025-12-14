using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using Unity.Collections;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{
    public PLayers p;
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
        ketiga,
        keempat
    }
    public Stages stage;
    public int hit;
    public float speed;
    public int currenttWaktu;

    //prefab jalan
    public List<GameObject> blokEnemy1= new List<GameObject>(); 
    public List<GameObject> blokEnemy2= new List<GameObject>(); 
    public List<GameObject> blokEnemy3= new List<GameObject>(); 
    public List<GameObject> blokEnemy4= new List<GameObject>(); 
    public List<List<GameObject>> blokEnemy = new List<List<GameObject>>{}; 


    void Start()
    {
        
        stage = Stages.pertama;
        //speed jalan
        currenttWaktu=0;
        StartCoroutine(nambah());

        hit = 0;

        p = GameObject.Find("player").GetComponent<PLayers>(); // ngambil state di gama manager
        
        Status= GameState.maju;
        RefreshActiveBlocks();

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
    
        //ganti stage
        if (currenttWaktu > 5 && currenttWaktu <= 10) stage = Stages.kedua;
        else if (currenttWaktu > 10 && currenttWaktu <= 15) stage = Stages.ketiga;
        else if (currenttWaktu > 15 && currenttWaktu <= 20) stage = Stages.keempat;
    }

    void RefreshActiveBlocks()
    {
        blokEnemy.Clear();
        switch (stage)
        {
            case Stages.pertama:
                blokEnemy.Add(blokEnemy1);
                break;
            case Stages.kedua:
                blokEnemy.Add(blokEnemy2);
                break;
            case Stages.ketiga:
                blokEnemy.Add(blokEnemy3);
                break;
            case Stages.keempat:
                blokEnemy.Add(blokEnemy4);
                break;
        }
    }

    IEnumerator nambah()
    {
        //kecepatan maju
        while (true) 
        {
            p.speed += 0.5f;
            currenttWaktu += 1;
            if (currenttWaktu <= 5) speed += 0.5f;
            else if (currenttWaktu <= 10) speed += 1f;
            else if (currenttWaktu <= 15) speed += 2f;
            else speed += 4f;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
