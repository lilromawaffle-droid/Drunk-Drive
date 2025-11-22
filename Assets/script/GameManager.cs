using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;


public class GameManager : MonoBehaviour
{

    public bool menang=false;
    public enum GameState
    {
        mulai,
        maju,
        menang,
        kalah
    }

    public GameState Status;

    void Update()
    {
        switch (Status)
        {
            case(GameState.mulai):
                break;
            case(GameState.maju):
                break;
            case(GameState.menang):
                menang=true;
                //buat animasi
                break;
            case(GameState.kalah):
                break;
        }        
    }
}
