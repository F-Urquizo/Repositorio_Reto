using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CreditsScript : MonoBehaviour
{
    public TMP_Text Credit_Tittle;
    void Start()
    {
        Credit_Tittle.text = "Credits";
    }


    void Update()
    {

    }

    public void ReturnMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HomeScreen");
    }
}
