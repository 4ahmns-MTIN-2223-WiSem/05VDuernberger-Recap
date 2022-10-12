using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerTicTacToe : MonoBehaviour
{
    //Array aus den  Elementen
    [SerializeField] private BoxTicTacToe[] arrayTTT;

   public Sprite spWhite, spX, spO;

    public bool player1;
    [SerializeField] private Image imgP1, imgP2;
    public Button resetBtn;
    public GameObject crownX, crownO;

    public int moves;
    public Text gameOverText;
    public bool someoneWon;


    // Start is called before the first frame update
    void Start()
    {
        player1 = false;
        ShowPlayer1Active(player1);
        moves = 0;
        resetBtn.interactable = false;
        crownX.SetActive(false);
        crownO.SetActive(false);
        someoneWon = false;
    }

    public void ShowPlayer1Active(bool isPLayer1)
    {
        if (isPLayer1)
        {
            imgP1.color = Color.green;
            imgP2.color = Color.white;
            moves = moves + 1;
        }
        else
        {
            imgP2.color = Color.green;
            imgP1.color = Color.white;
            moves = moves + 1;
        }
    }

    public void ResetBoard()
    {
        for (int i = 0; i < arrayTTT.Length; i++)
        {
            arrayTTT[i].SetImageBasedOnState(StateTTT.white);
        }
        moves = 0;
        resetBtn.interactable = false;
        crownX.SetActive(false);
        crownO.SetActive(false);
        someoneWon = false;
        player1 = false;
        ShowPlayer1Active(player1);
    }

    public void WinCheckX()
    {
        if (arrayTTT[0].myState == StateTTT.playerX && arrayTTT[1].myState == StateTTT.playerX && arrayTTT[2].myState == StateTTT.playerX)
        { GameOver(); someoneWon = true;
            Debug.Log("funktioniert");
        }
        else if (arrayTTT[3].myState == StateTTT.playerX && arrayTTT[4].myState == StateTTT.playerX && arrayTTT[5].myState == StateTTT.playerX)
        { GameOver(); someoneWon = true; }
        else if (arrayTTT[6].myState == StateTTT.playerX && arrayTTT[7].myState == StateTTT.playerX && arrayTTT[8].myState == StateTTT.playerX)
        { GameOver(); someoneWon = true; }
        else if (arrayTTT[0].myState == StateTTT.playerX && arrayTTT[3].myState == StateTTT.playerX && arrayTTT[6].myState == StateTTT.playerX)
        { GameOver(); someoneWon = true; }
        else if (arrayTTT[1].myState == StateTTT.playerX && arrayTTT[4].myState == StateTTT.playerX && arrayTTT[7].myState == StateTTT.playerX)
        { GameOver(); someoneWon = true; }
        else if (arrayTTT[2].myState == StateTTT.playerX && arrayTTT[5].myState == StateTTT.playerX && arrayTTT[8].myState == StateTTT.playerX)
        { GameOver(); someoneWon = true; }
        else if (arrayTTT[0].myState == StateTTT.playerX && arrayTTT[4].myState == StateTTT.playerX && arrayTTT[8].myState == StateTTT.playerX)
        { GameOver(); someoneWon = true; }
        else if (arrayTTT[2].myState == StateTTT.playerX && arrayTTT[4].myState == StateTTT.playerX && arrayTTT[6].myState == StateTTT.playerX)
        { GameOver(); someoneWon = true; }
    }


    public void WinCheckO()
    {
        if (arrayTTT[0].myState == StateTTT.playerO && arrayTTT[1].myState == StateTTT.playerO && arrayTTT[2].myState == StateTTT.playerO)
        {
            GameOver2(); someoneWon = true;
            Debug.Log("funktioniert scho wieda");
        }
        else if (arrayTTT[3].myState == StateTTT.playerO && arrayTTT[4].myState == StateTTT.playerO && arrayTTT[5].myState == StateTTT.playerO)
        { GameOver2(); someoneWon = true; }
        else if (arrayTTT[6].myState == StateTTT.playerO && arrayTTT[7].myState == StateTTT.playerO && arrayTTT[8].myState == StateTTT.playerO)
        { GameOver2(); someoneWon = true; }
        else if (arrayTTT[0].myState == StateTTT.playerO && arrayTTT[3].myState == StateTTT.playerO && arrayTTT[6].myState == StateTTT.playerO)
        { GameOver2(); someoneWon = true; }
        else if (arrayTTT[1].myState == StateTTT.playerO && arrayTTT[4].myState == StateTTT.playerO && arrayTTT[7].myState == StateTTT.playerO)
        { GameOver2(); someoneWon = true; }
        else if (arrayTTT[2].myState == StateTTT.playerO && arrayTTT[5].myState == StateTTT.playerO && arrayTTT[8].myState == StateTTT.playerO)
        { GameOver2(); someoneWon = true; }
        else if (arrayTTT[0].myState == StateTTT.playerO && arrayTTT[4].myState == StateTTT.playerO && arrayTTT[8].myState == StateTTT.playerO)
        { GameOver2(); someoneWon = true; }
        else if (arrayTTT[2].myState == StateTTT.playerO && arrayTTT[4].myState == StateTTT.playerO && arrayTTT[6].myState == StateTTT.playerO)
        { GameOver2(); someoneWon = true; }
    }

    public void TieCheck()
    {
        if (moves >= 9)
        {
            gameOverText.text = "Tie!";
            resetBtn.interactable = true;
        }

        if(someoneWon == false)
        {
            gameOverText.text = "Keep Playing!";
        }
    }

    void Update()
    {
        WinCheckX();
        WinCheckO();
        TieCheck();
    }

    public void GameOver()
    {
        Debug.Log("geht der scheiß?");
        gameOverText.text = "the game is over - The winner is wearing a crown!";
        crownX.SetActive(true);
        resetBtn.interactable = true;
    }
    public void GameOver2()
    {
        Debug.Log("geht der scheiß?scho wieda");
        gameOverText.text = "the game is over - The winner is wearing a crown!";
        crownO.SetActive(true);
        resetBtn.interactable = true;
    }
}
