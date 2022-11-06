using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TempoFase : MonoBehaviour
{
    public int minutos;
    public int segundos;
    static int dia;
    [SerializeField]
    private Text textoMinutos;
    [SerializeField]
    private Text textoSegundos;
    [SerializeField]
    private Text textoDia;

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

        if(minutos <= 2) {
            //Condicao
        }

        if(minutos <= 0 && segundos <= 1){
            ReiniciarBotao();
        }
    }

    public void ReiniciarBotao() {
        textoDia.text = dia.ToString();
        dia++;
        Dia();
        SceneManager.LoadScene("TransicaoDia");
        Time.timeScale = 1;
    }

    public void Dia(){
        if(dia >= 1) Debug.Log("Dia");
    }

    IEnumerator Contar() {
        while(segundos <= 59) {
            yield return new WaitForSeconds(1);
            segundos--;
            yield return null;
        }
    }
}
