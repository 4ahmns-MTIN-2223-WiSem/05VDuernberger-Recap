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



    // Start is called before the first frame update
    void Start()
    {

        buttonBlue.GetComponent<Image>().color = Color.blue;
        buttonGreen.GetComponent<Image>().color = Color.green;
        buttonRed.GetComponent<Image>().color = Color.red;

        buttonNextScene.interactable = false;

     }


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
        if (buttonNumber == 0)
            blueButtonSwitched = true;

        if (buttonNumber == 1)
            greenButtonSwitched = true;

        if (buttonNumber == 2)
            redButtonSwitched = true;

        if (blueButtonSwitched && greenButtonSwitched && redButtonSwitched)
            buttonNextScene.interactable = true;
    }


    public void SwitchTheScene()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToFirstScene()
    {
        SceneManager.LoadScene(0);
    }

}
