using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public enum TTTState
{
    W,
    O,
    X
}

public class TicTacToeElement : MonoBehaviour
{

    public TTTState myState = TTTState.W;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if (myState == TTTState.X)
        {
            gameObject.GetComponent<Image>().color = Color.yellow;
            gameObject.GetComponent<Button>().interactable = false;
        }

        if (myState == TTTState.O)
        {
            gameObject.GetComponent<Image>().color = Color.blue;
            gameObject.GetComponent<Button>().interactable = false;
        }

        if (myState == TTTState.W)
        {
            gameObject.GetComponent<Image>().color = Color.white;
            gameObject.GetComponent<Button>().interactable = true;
        }
       */
    }




}
