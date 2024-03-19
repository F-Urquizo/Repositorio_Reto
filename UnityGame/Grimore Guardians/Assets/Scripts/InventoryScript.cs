using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    public void ReturnMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HomeScreen");
    }
}
