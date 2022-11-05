using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Passageiro : MonoBehaviour
{

    [SerializeField] private int idade;  //10-90?
    [SerializeField] private float altura;  //1,48 - 1,98
    [SerializeField] private float dinheiroParaPassagem; //
    private enum CorDaRoupa
    {
        Azul,
        Verde,
        Vermelho
    }
    [SerializeField] private CorDaRoupa corRoupa;
    private enum TimeFutebol
    {
        Palmeiras,
        Corinthians,
        Cruzeiro
    }
    [SerializeField] private  TimeFutebol timeFutebol;
    private enum Profissao
    {
        Advogado,
        Medico,
        Programador
    }
    [SerializeField] private  Profissao profissao;
    private enum GeracaoPokemon
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
    [SerializeField] private GeracaoPokemon geracaoPokemon;
    private enum RoleLOL
    {
        Top,
        Jungle,
        Mid,
        ADC,
        Suporte
    }
    [SerializeField] private RoleLOL roleLOL;

    private enum CorDoCabelo
    {
        Preto,
        Loiro,
        Ruivo
    }
    [SerializeField] private CorDoCabelo corCabelo;
    private enum Acessorios
    {
        Corrente,
        Pulseira,
        Brinco
    }
    [SerializeField] private  Acessorios acessorios;



    private void Start()
    {
        idade = Random.Range(15, 90);
        altura = Random.Range(1.50f, 1.90f);
        altura = Mathf.Round(altura * 100.0f) * 0.01f;
        dinheiroParaPassagem = Random.Range(1.50f, 1.90f);
        dinheiroParaPassagem = Mathf.Round(dinheiroParaPassagem * 100.0f) * 0.01f;
        corRoupa = (CorDaRoupa)Random.Range(0, 3);
        timeFutebol = (TimeFutebol)Random.Range(0, 3);
        profissao = (Profissao)Random.Range(0, 3);
        geracaoPokemon = (GeracaoPokemon)Random.Range(0, 8);
        roleLOL = (RoleLOL)Random.Range(0, 5);
        corCabelo = (CorDoCabelo)Random.Range(0, 3);
        acessorios = (Acessorios)Random.Range(0, 3);

    }
}
