using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject menuClicado;

    public void Jogar() {
        SceneManager.LoadScene("Jogo");
    }

    public void AbrirComoJogar() {
        menuClicado.SetActive(true);
    }

    public void AbrirControles() {
        menuClicado.SetActive(true);
    }

    public void Sair() {
        Application.Quit();
    }
}
