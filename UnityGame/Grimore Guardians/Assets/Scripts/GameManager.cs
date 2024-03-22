using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    private bool CardPlaced;

    public GameObject myButton;
    public GameObject currentCard;
    public Canvas canvas;
    private Image texturaImagen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveCardToAttack()
    {
        if (!CardPlaced)
        {
            texturaImagen = myButton.GetComponent<Image>();
            Destroy(myButton.gameObject);

            // Crear un nuevo GameObject para la imagen
            GameObject nuevaImagenGO = new GameObject("ActiveCard");
            // Establecer el transform del nuevo GameObject
            RectTransform rt = nuevaImagenGO.AddComponent<RectTransform>();
            rt.SetParent(canvas.transform, false); // Establecer el Canvas como el padre y mantener la escala del GameObject

            // Agregar un componente RawImage al GameObject para mostrar la imagen
            RawImage nuevaImagen = nuevaImagenGO.AddComponent<RawImage>();
            nuevaImagen.texture = texturaImagen.mainTexture; // Asignar la textura del Image al RawImage

            rt.sizeDelta = new Vector2(80, 120);
            // Ajustar la posición de la imagen dentro del Canvas
            rt.anchoredPosition = Vector2.zero; // Por ejemplo, colocamos la imagen en el centro del Canvas
            CardPlaced = true;
        }
    }

    public void DiscardCard()
    {
        if (CardPlaced)
        {
            currentCard = GameObject.Find("ActiveCard");
            RectTransform cardTransform = currentCard.GetComponent<RectTransform>();
            cardTransform.anchoredPosition = new Vector2(237f, -220f);
            // Destroy(currentCard.gameObject);
        }
    }
}
