using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicadorFregadero : MonoBehaviour
{

    public GameObject textObject;

    // Start is called before the first frame update
    void Start()
    {
        if (textObject != null)
        {
            textObject.SetActive(false);
        }
        
    }

     private void OnTriggerEnter(Collider other)
    {
        // Verifica si el personaje entra en el área
        if (other.CompareTag("Untagged"))
        {
            if (textObject != null)
            {
                textObject.SetActive(true); // Muestra el texto
            }
        }
    }

     private void OnTriggerExit(Collider other)
    {
        // Verifica si el personaje sale del área
        if (other.CompareTag("Untagged"))
        {
            if (textObject != null)
            {
                textObject.SetActive(false); // Oculta el texto
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
