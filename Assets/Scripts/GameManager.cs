using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject winnerUI;
    public GameObject player;
    //Level Switcher Code
    public GameObject levelOne;
    public GameObject levelTwo;
    public int currentLevel = 1;

    private void Update()
    {
       if(gameOver == true)
       {
            GameOver();
       }

       if(currentLevel == 2)
       {
        levelOne.SetActive(false);
        levelTwo.SetActive(true);
       }
    }

    void GameOver() {
        player.GetComponent<Player>().enabled = false;
        Destroy(player.GetComponent<Rigidbody>());
        winnerUI.SetActive(true);
        gameObject.SetActive(false);
    }
}
