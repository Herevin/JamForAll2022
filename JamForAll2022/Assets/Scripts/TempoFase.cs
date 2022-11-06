using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TempoFase : MonoBehaviour
{
    public int minutos;
    public int segundos;
    [SerializeField]
    private Text textoMinutos;
    [SerializeField]
    private Text textoSegundos;

    void Start()
    {
        StartCoroutine("Contar");
    }

    void Update()
    {
        textoMinutos.text = minutos.ToString();
        textoSegundos.text = segundos.ToString();

        if(segundos <= 0) {
            minutos--;
            segundos = 59;
        }

        if(minutos <= 0 && segundos <= 1){
            ReiniciarBotao();
        }
    }

    public void ReiniciarBotao() {
        SceneManager.LoadScene("TransicaoDia");
        Time.timeScale = 1;
    }

    IEnumerator Contar() {
        while(segundos <= 59) {
            yield return new WaitForSeconds(1);
            segundos--;
            yield return null;
        }
    }
}
