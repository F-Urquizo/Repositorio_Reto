using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    // General Game Variables
    private int round;  // in charge of keeping count of rounds
    public GameObject[] Deck; // List of all cards in deck
    private GameObject Card;
    private int MaxHandCards = 5; // Define how many cards are going to be in hand max

    // Hand variables
    public GameObject[] Hand; // List of cards in Hand
    private int NumCardsHand; // number of cards held in hand
    public GameObject content; // Zone where new cards are going to be placed

    // Adding card to Attack variables 
    private bool CardPlaced;
    public GameObject currentCard; // recives active card and moves it to discard zone
    public Canvas canvas;
    private Image texturaImagen; // In charge of getting image component from button cards

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddCardToHand()
    {
        NumCardsHand = Hand.Length; // set number of cards depending on how many cards are in hand
        Debug.Log("Num Cards: " + NumCardsHand); // prints value on terminal (doesn't affects gameplay)

        if (NumCardsHand < MaxHandCards) // make sure not to have more than 5 cards in hand
        {
            for (int count = NumCardsHand; count < MaxHandCards; count++) // Gives player n cards for it to have 5 cards in hand at the beggining of each round
            {

                //CARD BUTTON BUILD

                GameObject NewCardToHand = new GameObject("Card" + NumCardsHand.ToString()); // Create Empty GameObject called Card + number, eg Card2,Card3...
                RectTransform rt = NewCardToHand.AddComponent<RectTransform>(); // Add RectTransfrom component to move it into a particular place later
                RawImage CardImage = NewCardToHand.AddComponent<RawImage>(); // Add RawImage component to add a card image later
                Button buttonComponent = NewCardToHand.AddComponent<Button>(); // Add Button component to interact with the card later
                texturaImagen = Deck[0].GetComponent<Image>(); // Set the image we want from the image of a card saved in our deck, change later for a random card in deck
                CardImage.texture = texturaImagen.mainTexture; // Asignar la textura del Image al RawImage
                rt.SetParent(content.transform, false); // Placed the new Button Card into the content container

                buttonComponent.onClick.AddListener(() => MoveCardToAttack(NewCardToHand)); // NEED FIXING -> Add when On Click do MoveCardToAttack(NewCardToHand)

                System.Array.Resize(ref Hand, NumCardsHand + 1); // Increases length to Hand list to add new Button Card GameObject
                Hand[NumCardsHand] = NewCardToHand; // Adds new Button Card into Hand list
                NumCardsHand++; // Increases Number of cards in Hands -> Check if it´s disposable
            }
        }
    }
    public void MoveCardToAttack(GameObject button)
    {
        string buttonName = button.gameObject.name; // will be used to differentiate between cards in hand
        Debug.Log("Card name: " + buttonName); // prints buton pressed name (doesn´t affects gameplay)

        string tempButtonName; // Create a temporal string to compare with the Button pressed name
        List<GameObject> tempHand = new List<GameObject>(); // Define the temporary list to save the oher Buttons
        for (int index = 0; index < Hand.Length; index++)
        {
            tempButtonName = Hand[index].gameObject.name; // The temporal string will take each GameObjects saved in the Hand list 
            if (buttonName != tempButtonName)
            {
                tempHand.Add(Hand[index]);
                /*
                We need to save the Buttons we didn´t clicked
                this way we can update our hand list, since
                our Hand "list" isn´t really a list but an Array
                we need to use different methods to update it.
                 */
            }

        }

        if (!CardPlaced)
        {
            Hand = tempHand.ToArray(); // We convert the temporal list into an array to match Hand variable type

            texturaImagen = button.GetComponent<Image>(); // Set Image into the image saved in the Button

            Destroy(button.gameObject); // Destroy button inside UI Hand
            Destroy(currentCard.gameObject); // If exists, destroy card in the discard pile to avoid garvage

            GameObject nuevaImagenGO = new GameObject("ActiveCard"); /* Create new empty GameObject called ActiveCard
            This Active card is going to be the card we selected and wanted to go into battle (the card in the middle of the canvas) */

            RectTransform rt = nuevaImagenGO.AddComponent<RectTransform>();  // Add RectTransfrom component to move it into a particular place later
            rt.SetParent(canvas.transform, false); // Set the Canvas as the parent and keep the GameObject's scale
            rt.sizeDelta = new Vector2(100, 130); // Set Size of the GameObect Width = 100, Height = 130
            rt.anchoredPosition = Vector2.zero; // Placed the GameObject in the middle of the canvas x=0 y=0

            RawImage nuevaImagen = nuevaImagenGO.AddComponent<RawImage>(); // Add RawImage component to add a card image late
            nuevaImagen.texture = texturaImagen.mainTexture; // Set image into the GameObject with the Button Image we saved before

            CardPlaced = true; //Now we have a card place into battle, therefore we set CardPlaced on true
            NumCardsHand--; // We update number of cards in hand -> Check if it´s disposable
        }
    }
    public void DiscardCard()
    {
        if (CardPlaced)
        {
            currentCard = GameObject.Find("ActiveCard"); // Set current card into Active card, which is the one we placed into battle
            RectTransform cardTransform = currentCard.GetComponent<RectTransform>(); // Gets the RectTransfrom component so we can manipulate it and chenge its position
            cardTransform.anchoredPosition = new Vector2(470f, -220f); // Change positions where is going to be the discard pile 
            CardPlaced = false; // Since we lost out troop, we set our placedCard to false
        }
    }



}
