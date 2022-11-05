using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Passageiro : MonoBehaviour
{

     public int idade;  //10-90?
     public float altura;  //1,48 - 1,98
     public float dinheiroParaPassagem; //
    public enum TipoPagamento
    {
        Cartão,
        Dinheiro
    }
    public TipoPagamento tipoPagamento;
    public enum CorDaRoupa
    {
        Azul,
        Verde,
        Vermelho
    }
     public CorDaRoupa corRoupa;
    public enum TimeFutebol
    {
        Palmeiras,
        Corinthians,
        Cruzeiro
    }
     public  TimeFutebol timeFutebol;
    public enum Profissao
    {
        Advogado,
        Medico,
        Programador
    }
     public  Profissao profissao;
    public enum GeracaoPokemon
    {
        Kanto,
        Johto,
        Hoenn,
        Sinnoh,
        Unova,
        Kalos,
        Alola,
        Galar
    }
     public GeracaoPokemon geracaoPokemon;
    public enum RoleLOL
    {
        Top,
        Jungle,
        Mid,
        ADC,
        Suporte
    }
     public RoleLOL roleLOL;

    public enum CorDoCabelo
    {
        Preto,
        Loiro,
        Ruivo
    }
     public CorDoCabelo corCabelo;
    public enum Acessorios
    {
        Corrente,
        Pulseira,
        Brinco
    }
     public  Acessorios acessorios;


    private GameObject ficha;


    public void Start()
    {
        idade = Random.Range(15, 90);
        altura = Random.Range(1.50f, 1.90f);
        altura = Mathf.Round(altura * 100.0f) * 0.01f;
        tipoPagamento = (TipoPagamento)Random.Range(0, 2);
        dinheiroParaPassagem = Random.Range(1.50f, 1.90f);
        dinheiroParaPassagem = Mathf.Round(dinheiroParaPassagem * 100.0f) * 0.01f;
        corRoupa = (CorDaRoupa)Random.Range(0, 3);
        timeFutebol = (TimeFutebol)Random.Range(0, 3);
        profissao = (Profissao)Random.Range(0, 3);
        geracaoPokemon = (GeracaoPokemon)Random.Range(0, 8);
        roleLOL = (RoleLOL)Random.Range(0, 5);
        corCabelo = (CorDoCabelo)Random.Range(0, 3);
        acessorios = (Acessorios)Random.Range(0, 3);


        ficha = GameObject.Find("InformacoesFicha");
        ficha.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Idade" +"\n" +idade.ToString();
        ficha.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "Altura" + "\n" + altura.ToString();
        ficha.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = "Dinheiro" + "\n" + dinheiroParaPassagem.ToString();
        ficha.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "Time" + "\n" + timeFutebol.ToString();
        ficha.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = "Profissao" + "\n" + profissao.ToString();
        ficha.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = "Pokemon" + "\n" + geracaoPokemon.ToString();
        ficha.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = "RoleLol" + "\n" + roleLOL.ToString();
        ficha.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = "Acessorios" + "\n" + acessorios.ToString();

        GameObject.FindObjectOfType<SistemaPontuacao>().passageiroExaminado = this;
    }
}
