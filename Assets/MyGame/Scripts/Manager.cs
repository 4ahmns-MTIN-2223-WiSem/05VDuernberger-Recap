using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Manager : MonoBehaviour
{

    public Button buttonBlue;
    public Button buttonGreen;
    public Button buttonRed;

    public Button buttonNextScene;
    public Button buttonAgain;

    private bool blueButtonSwitched;
    private bool greenButtonSwitched;
    private bool redButtonSwitched;


    void Start()
    {

        buttonBlue.GetComponent<Image>().color = Color.blue;
        buttonGreen.GetComponent<Image>().color = Color.green;
        buttonRed.GetComponent<Image>().color = Color.red;

        buttonNextScene.interactable = false;

     }


    /*public int GetValUpTo255()
    {
        return (int)Random.Range(0f, 255f);
    }

    private Color GetRandomColor()
    {
        Color a = new Color32(GetValUpTo255, GetValUpTo255, GetValUpTo255, GetValUpTo255);
        return a;
    }
    */

    public void blueDifferent()
    {
        buttonBlue.GetComponent<Image>().color = Random.ColorHSV();
    }

    public void greenDifferent()
    {
        buttonGreen.GetComponent<Image>().color = Random.ColorHSV();
    }
    public void redDifferent()
    {
        buttonRed.GetComponent<Image>().color = Random.ColorHSV();
    }

    public void isChanged(int buttonNumber)
    {

        /* switch (buttonNumber)
        {
            case1:
                buttonBlue.GetComponent<Image>().color = Color.yellow;
                blueDifferent = true;
                break;
            case2:
                buttonGreen.GetComponent<Image>().color = Color.yellow;
                greenDifferent = true;
                break;
            case2:
                buttonRed.GetComponent<Image>().color = Color.yellow;
                redDifferent = true;
                break;
      } */


        if (buttonNumber == 0)
            blueButtonSwitched = true;

        if (buttonNumber == 1)
            greenButtonSwitched = true;

        if (buttonNumber == 2)
            redButtonSwitched = true;
        // !buttonNextScene.Interactable && ...  ist auch möglich
        if (buttonNextScene.interactable == false && blueButtonSwitched && greenButtonSwitched && redButtonSwitched)
            buttonNextScene.interactable = true;
    }


    public void SwitchTheScene()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(1);
    }

}
