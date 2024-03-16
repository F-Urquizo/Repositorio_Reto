using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject myButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveButton()
    {
        RectTransform buttonTransform = myButton.GetComponent<RectTransform>();
        buttonTransform.anchoredPosition = new Vector2(0, -20);
    }
}
