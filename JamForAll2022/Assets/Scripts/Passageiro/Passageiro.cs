using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Passageiro : MonoBehaviour
{

    public int idade;  //10-90?
    public float altura;  //1,48 - 1,98  
    public bool fotoCorresponde;
    public enum Destino
    {
        Arujá, Cavalinhos, Numbani, SanAndreas, Guarulhos
    }
    public Destino destino;
    public enum TimeFutebol
    {
        Internacional, Sport, Vasco, Paysandu, Goiás

    }
    public TimeFutebol timeFutebol;
    public enum Profissao
    {
        Padeiro, Estudante, Streamer, Monge, Advogado
    }
    public Profissao profissao;
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

    public enum Acessorios
    {
        Óculos, Brinco, Chapéu, Piercing, Colar
    }
    public Acessorios acessorios;
    [SerializeField] public bool naoPossuiAcc;

    public enum TipoPagamento
    {
        Cartão,
        Dinheiro
    }
    public TipoPagamento tipoPagamento;
    public float dinheiroParaPassagem;
    [HideInInspector] public SpriteRenderer mySR;
    [SerializeField] public Sprite[] mySpriteVariants;
    //0 - Oculos
    //1 - Brinco
    //2 - Chapéu
    //3 - Piercing
    //4 - Colar
    [HideInInspector] public Sprite mySprite;

    public Sprite[] wrongSprite;
    [HideInInspector] public GameObject ficha;



    public void RevelarTimeFutebol()
    {
        ficha.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = "Time" + "\n" + timeFutebol.ToString();
             
    }
    public void RevelarGeracaoPokemon()
    {
       
        ficha.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = "Pokemon" + "\n" + geracaoPokemon.ToString();
    }

    public void RevelarProfissao()
    {
        ficha.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = "Profissao" + "\n" + profissao.ToString();
    }

    public void RevelarRoleLOL()
    {
        ficha.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = "RoleLol" + "\n" + roleLOL.ToString();
    }
}
