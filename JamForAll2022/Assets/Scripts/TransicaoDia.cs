using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicaoDia : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene("Jogo");
        }
    }

    public void IrMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void JogarNovamente()
    {
        SceneManager.LoadScene("Jogo");
    }
}
