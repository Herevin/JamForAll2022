using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RegrasChefe : Passageiro
{
    //Idade              0
    //Altura             1
    //Forma Pagamento    2
    //Quantia Dinheiro   3
    //Cor da Roupa       4
    //Time Futebol       5
    //Profissao          6
    //Geracao Pokemon    7
    //Role no LOL        8
    //Cor Cabelo         9
    //Acessorio          10


    public bool[] avaliacoes = new bool[10];

    [SerializeField] private TextMeshProUGUI[] regras;

    private void Start()
    {
        RandomizarRegra(2);
    }
    public void RandomizarRegra(int quantidade)
    {
        int totalRegras = quantidade;
        ResetarBooleanas();
        while (quantidade > 0)
        {
            
            int randomizador = Random.Range(0, 11);
            switch (randomizador)
            {
                case 0:
                    if (avaliacoes[randomizador]) break;
                    avaliacoes[randomizador] = true;
                    idade = Random.Range(30, 61);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = idade < 45 ? "Maiores que" + idade + " idade" : "Menores que" + idade + " idade";
                    break;
                case 1:
                    if (avaliacoes[randomizador]) break;
                   avaliacoes[randomizador] = true;
                    altura = Random.Range(1.65f, 1.75f);
                    altura = Mathf.Round(altura * 100.0f) * 0.01f;
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = altura < 1.7f ? "Maiores que" + altura + " de altura" : "Menores que" + altura + " de altura";

                    break;
                case 2:
                    if (avaliacoes[randomizador]) break;
                    avaliacoes[randomizador] = true;
                    tipoPagamento = (TipoPagamento)Random.Range(0, 2);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = tipoPagamento.ToString();
                    break;
                case 3:
                    if (avaliacoes[randomizador]) break;
                    avaliacoes[randomizador] = true;
                    dinheiroParaPassagem += Random.Range(1, 3);
                    dinheiroParaPassagem -= Random.Range(1, 3);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = dinheiroParaPassagem.ToString();
                    break;
                case 4:
                    if (avaliacoes[randomizador]) break;
                    avaliacoes[randomizador] = true;
                    corRoupa = (CorDaRoupa)Random.Range(0, 3);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = corRoupa.ToString();
                    break;
                case 5:
                    if (avaliacoes[randomizador]) break;
                    avaliacoes[randomizador] = true;
                    timeFutebol = (TimeFutebol)Random.Range(0, 3);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = timeFutebol.ToString();
                    break;
                case 6:
                    if (avaliacoes[randomizador]) break;
                    avaliacoes[randomizador] = true;
                    profissao = (Profissao)Random.Range(0, 3);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = profissao.ToString();
                    break;
                case 7:
                    if (avaliacoes[randomizador]) break;
                    avaliacoes[randomizador] = true;
                    geracaoPokemon = (GeracaoPokemon)Random.Range(0, 8);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = geracaoPokemon.ToString();
                    break;
                case 8:
                    if (avaliacoes[randomizador]) break;
                    avaliacoes[randomizador] = true;
                    roleLOL = (RoleLOL)Random.Range(0, 5);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = roleLOL.ToString();
                    break;
                case 9:
                    if (avaliacoes[randomizador]) break;
                   avaliacoes[randomizador] = true;
                    corCabelo = (CorDoCabelo)Random.Range(0, 3);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = corCabelo.ToString();
                    break;
                case 10:
                    if (avaliacoes[randomizador]) break;
                    avaliacoes[randomizador] = true;
                    acessorios = (Acessorios)Random.Range(0, 3);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = acessorios.ToString();
                    break;

            }
            quantidade--;
        }





    }

    private void ResetarBooleanas()
    {
        for (int i = 0; i < avaliacoes.Length; i++)
        {
            avaliacoes[i] = false;
        }
        for (int i = 0; i < regras.Length; i++)
        {
            regras[i].gameObject.SetActive(false);
            regras[0].gameObject.SetActive(true);
        }
    }

    private void AtualizarUI(int quantidade)
    {
        
    }
}
