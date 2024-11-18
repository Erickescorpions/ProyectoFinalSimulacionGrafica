using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InteraccionObjeto : MonoBehaviour
{
    public float distanciaDeInteraccion = 3f;
    public TMP_Text mensajeUI;
    public GameObject jugador; // Referencia directa al GameObject del jugador
    private bool enRango = false;

    void Update()
    {
        if (mensajeUI == null)
        {
            Debug.LogError("El campo 'mensajeUI' no está asignado en el Inspector.");
            return;
        }

        if (enRango)
        {
            mensajeUI.text = "Presiona E para entrar";

            if (Input.GetKeyDown(KeyCode.E))
            {
                Entrar();
            }
        }
        else
        {
            mensajeUI.text = "";
        }
    }

    void Entrar()
    {
        // Obtener la escena activa
        Scene currentScene = SceneManager.GetActiveScene();

        // Verificar el nombre de la escena actual y cambiar a la otra
        if (currentScene.name == "Casa")
        {
            SceneManager.LoadScene("Isla");
        }
        else if (currentScene.name == "Isla")
        {
            SceneManager.LoadScene("Casa");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Comprobar si el objeto que entra es el jugador
        if (other.gameObject == jugador)
        {
            enRango = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Comprobar si el objeto que sale es el jugador
        if (other.gameObject == jugador)
        {
            enRango = false;
        }
    }
}
