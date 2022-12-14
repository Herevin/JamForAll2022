using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TempoFase : MonoBehaviour
{
    public int minutos;
    public int segundos;
    public static int dia;
    [SerializeField]
    private Text textoMinutos;
    [SerializeField]
    private Text textoSegundos;
    [SerializeField]
    public Text textoDia;
    RegrasChefe randomTraits;

    bool chamouDoDia;

    void Start()
    {
        StartCoroutine("Contar");
        textoDia.text = dia.ToString();
        randomTraits = GameObject.FindObjectOfType<RegrasChefe>();
        Debug.Log(dia);
    }

    void Update()
    {
        textoMinutos.text = minutos.ToString();
        textoSegundos.text = segundos.ToString();

        if(segundos <= 0) {
            minutos--;
            segundos = 59;
        }

        if(minutos <= 0 && segundos <= 1) {
            ReiniciarBotao();
        }

        if(minutos == 2 && segundos == 1) {
            ChamarTraitsNovas();
        }

        if(dia == 0 || dia == 1) {
            if(minutos == 2 && segundos == 1) {
                ChamarTraitsNovas();
            }
        }

        if(dia == 2 || dia == 3) {
            if(minutos == 3 && segundos == 30) {
                ChamarTraitsNovas();
            }
            if(minutos == 2 && segundos == 1) {
                ChamarTraitsNovas();
            }
        }

        if(dia >= 4) {
            if(minutos == 3 && segundos == 30) {
                ChamarTraitsNovas();
            }
            if(minutos == 2 && segundos == 1) {
                ChamarTraitsNovas();
            } 
            if(minutos == 1 && segundos == 1) {
                ChamarTraitsNovas();
            }
        }
    }

    public void ReiniciarBotao() {
        textoDia.text = dia.ToString();
        dia++;
        SceneManager.LoadScene("TransicaoDia");
        Time.timeScale = 1;
    }

    IEnumerator JaChamouRegras()
    {
        chamouDoDia = true;
        yield return new WaitForSeconds(1.5f);
        chamouDoDia = false;
    }

    IEnumerator Contar() {
        while(segundos <= 59) {
            yield return new WaitForSeconds(1);
            segundos--;
            yield return null;
        }
    }

    public void ChamarTraitsNovas() {
        if (chamouDoDia) return;

        StartCoroutine(JaChamouRegras());

        switch (TempoFase.dia)
        {
            case 0:
                randomTraits.RandomizarRegra(3);
                break;
            case 1:
                randomTraits.RandomizarRegra(4);
                break;
            case 2:
                randomTraits.RandomizarRegra(5);
                break;
            case 3:
                randomTraits.RandomizarRegra(6);
                break;
            default:
                randomTraits.RandomizarRegra(7);
                break;
        }
        
    }
}
