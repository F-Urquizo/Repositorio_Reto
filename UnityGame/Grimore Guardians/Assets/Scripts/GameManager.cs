using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject myButton;
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

    public void MoveButtonToAttack()
    {
        texturaImagen = myButton.GetComponent<Image>();
        Destroy(myButton.gameObject);

        // Crear un nuevo GameObject para la imagen
        GameObject nuevaImagenGO = new GameObject("Imagen");
        // Establecer el transform del nuevo GameObject
        RectTransform rt = nuevaImagenGO.AddComponent<RectTransform>();
        rt.SetParent(canvas.transform, false); // Establecer el Canvas como el padre y mantener la escala del GameObject

        // Agregar un componente RawImage al GameObject para mostrar la imagen
        RawImage nuevaImagen = nuevaImagenGO.AddComponent<RawImage>();
        nuevaImagen.texture = texturaImagen.mainTexture; // Asignar la textura del Image al RawImage

        rt.sizeDelta = new Vector2(80, 120);
        // Ajustar la posición de la imagen dentro del Canvas
        rt.anchoredPosition = Vector2.zero; // Por ejemplo, colocamos la imagen en el centro del Canvas
    }
}
