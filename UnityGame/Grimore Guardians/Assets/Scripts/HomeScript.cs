using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HomeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void EnterGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void EnterDeckScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("InventoryScene");
    }

    public void EnterCreditScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CreditsScene");
    }
}
