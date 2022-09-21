using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GoBack : MonoBehaviour
{

    public Button buttonAgain;

    public void BackToFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
