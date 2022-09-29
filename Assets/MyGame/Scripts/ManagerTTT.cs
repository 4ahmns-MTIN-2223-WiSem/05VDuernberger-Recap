using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ManagerTTT : MonoBehaviour
{

   // public Image x;
    //public Image o;

    public bool player1;
    public bool player2;

    public GameObject textPlayer1;
    public GameObject textPlayer2;

    public int moves;
    public string side = "";
    public bool winStatus = false;


   /* public Button button;
    public Text buttonText;
    private GameController gameController;*/


    public TicTacToeElement[] game;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < game.Length; i++)
        {
            game[i].GetComponent<TicTacToeElement>().myState = TTTState.O;
        }

        player1 = true;
        player2 = !player1;
        moves = 0;
       

        if (player1)
        {
            textPlayer1.SetActive(true);
            textPlayer2.SetActive(false);
        }
        else
        {
            textPlayer1.SetActive(false);
            textPlayer2.SetActive(true);
        }


    }

    
       public string GetSide()
        {
            return side;
        }

        void ChangeSide()
        {
            if (side == "X")
                side = "O";
            else
                side = "X";
        }
   

    // Update is called once per frame
    void Update()
    {

    }

    public void EndTurn()
    {
        moves++;
        ChangeSide();
    }



    /*public void EndTurn()
    {
        moves++;
        if (myState[0].text == side && myState[1].text == side && myState[2].text == side)
            GameOver();
        else if (myState[3].text == side && myState[4].text == side && myState[5].text == side)
            GameOver();
        else if (myState[6].text == side && myState[7].text == side && myState[8].text == side)
            GameOver();
        else if (myState[0].text == side && myState[3].text == side && myState[6].text == side)
            GameOver();
        else if (myState[1].text == side && myState[4].text == side && myState[7].text == side)
            GameOver();
        else if (myState[2].text == side && myState[5].text == side && myState[8].text == side)
            GameOver();
        else if (myState[0].text == side && myState[4].text == side && myState[8].text == side)
            GameOver();
        else if (myState[2].text == side && myState[4].text == side && myState[6].text == side)
            GameOver();
        if (moves >= 9)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "Tie!";
            restartButton.SetActive(true);
        }
        ChangeSide();
    }*/

    /*public void SelectedBox(int box)
    {
        if (player1)
        {
            game[box].GetComponent<TicTacToeElement>().myState = TTTState.X;

            player1 = false;
        }
        else
        {
            game[box].GetComponent<TicTacToeElement>().myState = TTTState.O;
            player1 = true;
        }
    }*/
}