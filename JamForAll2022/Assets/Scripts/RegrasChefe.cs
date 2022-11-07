using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RegrasChefe : Passageiro
{
    //Idade              0
    //Altura             1
    //Destino            2
    //Foto               3
    //Time Futebol       4
    //Profissao          5
    //Geracao Pokemon    6
    //Role no LOL        7
    //Acessorio          8


    //Forma Pagamento  
    //Quantia Dinheiro 


    [HideInInspector]public bool[] avaliacoes = new bool[9];

    [SerializeField] private TextMeshProUGUI[] regras;

    [SerializeField] private GameObject afonsoText;
    [SerializeField] private GameObject aristeuText;

    [HideInInspector]public bool aristeu;

    private void Start()
    {

        switch (TempoFase.dia) 
        {
            case 0:
                RandomizarRegra(3);
                break;
            case 1:
                RandomizarRegra(4);
                break;
            case 2:
                RandomizarRegra(5);
                break;
            case 3:
                RandomizarRegra(6);
                break;
            default:
                RandomizarRegra(7);
                break;
        }
        dinheiroParaPassagem = 8;
    }
    public void RandomizarRegra(int quantidade)
    {
        if (aristeu) aristeuText.SetActive(true);
        else afonsoText.SetActive(true);

        aristeu = !aristeu;

        int totalRegras = quantidade;
        ResetarBooleanas();

        while (quantidade > 0)
        {            
            int randomizador = Random.Range(0, 9);
            switch (randomizador)
            {
                case 0:
                    if (avaliacoes[randomizador]) 
                        {
                            quantidade += 1;
                            break;
                        }
                    avaliacoes[randomizador] = true;
                    idade = Random.Range(30, 61);
                    regras[Mathf.Abs(totalRegras - (quantidade))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade))].text = idade < 45 ? "- Não aceitamos passageiros com menos de " + idade + " anos" : "- Não aceitamos passageiros com mais de " + idade + " anos";
                    break;
                case 1:
                    if (avaliacoes[randomizador])
                        {
                            quantidade += 1;
                            break;
                        }
                    avaliacoes[randomizador] = true;
                    altura = Random.Range(1.65f, 1.75f);
                    altura = Mathf.Round(altura * 100.0f) * 0.01f;
                    regras[Mathf.Abs(totalRegras - (quantidade))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade))].text = altura < 1.7f ? "- Não aceitamos passageiros com menos de " + altura + "m de altura" : "- Não aceitamos passageiros com mais de " + altura + "m de altura";

                    break;
                case 2:
                    if (avaliacoes[randomizador]) 
                        {
                            quantidade += 1;
                            break;
                        }
                    avaliacoes[randomizador] = true;
                    destino = (Destino)Random.Range(0, 5);
                    regras[Mathf.Abs(totalRegras - (quantidade))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade))].text = "- Não aceitamos passageiros com destino para " + destino.ToString();
                    break;
                case 3:
                    if (avaliacoes[randomizador]) 
                        {
                            quantidade += 1;
                            break;
                        }
                    avaliacoes[randomizador] = true;                  
                    regras[Mathf.Abs(totalRegras - (quantidade))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade))].text = "- Não aceitamos passageiros com a foto irregular";
                    break;
                case 4:
                    if (avaliacoes[randomizador])
                    {
                        quantidade += 1;
                        break;
                    }
                    avaliacoes[randomizador] = true;
                    timeFutebol = (TimeFutebol)Random.Range(0, 5);
                    regras[Mathf.Abs(totalRegras - (quantidade))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade))].text = "- Não aceitamos passageiros que torcem para " +timeFutebol.ToString();
                    break;
                    
                case 5:
                    if (avaliacoes[randomizador])
                    {
                        quantidade += 1;
                        break;
                    }
                    avaliacoes[randomizador] = true;
                    profissao = (Profissao)Random.Range(0, 5);
                    regras[Mathf.Abs(totalRegras - (quantidade))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade))].text = "- Não aceitamos passageiros que atuam como " + profissao.ToString();
                    break;
                case 6:
                    if (avaliacoes[randomizador])
                    {
                        quantidade += 1;
                        break;
                    }
                    avaliacoes[randomizador] = true;
                    geracaoPokemon = (GeracaoPokemon)Random.Range(0, 8);
                    regras[Mathf.Abs(totalRegras - (quantidade))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade))].text = "- Não aceitamos passageiros que gostam da geração " + geracaoPokemon.ToString() + " do Pokemon";
                    break;
                    
                case 7:
                    if (avaliacoes[randomizador])
                    {
                        quantidade += 1;
                        break;
                    }
                    avaliacoes[randomizador] = true;
                    roleLOL = (RoleLOL)Random.Range(0, 5);
                    regras[Mathf.Abs(totalRegras - (quantidade))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade))].text = "- Não aceitamos passageiros main "+ roleLOL.ToString();
                    break;
                    
                case 8:
                    if (avaliacoes[randomizador])
                    {
                        quantidade += 1;
                        break;
                    }
                    avaliacoes[randomizador] = true;
                    acessorios = (Acessorios)Random.Range(0, 5);
                    regras[Mathf.Abs(totalRegras - (quantidade))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade))].text = "- Não aceitamos passageiros usando " + acessorios.ToString();
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


}
