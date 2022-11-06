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

    private void Start()
    {
        RandomizarRegra(3);
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
                    if (avaliacoes[randomizador]) 
                        {
                            quantidade += 1;
                            break;
                        }
                    avaliacoes[randomizador] = true;
                    idade = Random.Range(30, 61);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = idade < 45 ? "Menores que" + idade + " idade" : "Maiores que" + idade + " idade";
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
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = altura < 1.7f ? "Menores que" + altura + " de altura" : "Maiores que" + altura + " de altura";

                    break;
                case 2:
                    if (avaliacoes[randomizador]) 
                        {
                            quantidade += 1;
                            break;
                        }
                    avaliacoes[randomizador] = true;
                    destino = (Destino)Random.Range(0, 5);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = destino.ToString();
                    break;
                case 3:
                    if (avaliacoes[randomizador]) 
                        {
                            quantidade += 1;
                            break;
                        }
                    avaliacoes[randomizador] = true;                  
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = "Foto falsas";
                    break;
                case 4:
                    if (avaliacoes[randomizador])
                    {
                        quantidade += 1;
                        break;
                    }
                    avaliacoes[randomizador] = true;
                    timeFutebol = (TimeFutebol)Random.Range(0, 5);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = timeFutebol.ToString();
                    break;
                    
                case 5:
                    if (avaliacoes[randomizador])
                    {
                        quantidade += 1;
                        break;
                    }
                    avaliacoes[randomizador] = true;
                    profissao = (Profissao)Random.Range(0, 5);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = profissao.ToString();
                    break;
                case 6:
                    if (avaliacoes[randomizador])
                    {
                        quantidade += 1;
                        break;
                    }
                    avaliacoes[randomizador] = true;
                    geracaoPokemon = (GeracaoPokemon)Random.Range(0, 8);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = geracaoPokemon.ToString();
                    break;
                    
                case 7:
                    if (avaliacoes[randomizador])
                    {
                        quantidade += 1;
                        break;
                    }
                    avaliacoes[randomizador] = true;
                    roleLOL = (RoleLOL)Random.Range(0, 5);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].gameObject.SetActive(true);
                    regras[Mathf.Abs(totalRegras - (quantidade - 1))].text = roleLOL.ToString();
                    break;
                    
                case 8:
                    if (avaliacoes[randomizador])
                    {
                        quantidade += 1;
                        break;
                    }
                    avaliacoes[randomizador] = true;
                    acessorios = (Acessorios)Random.Range(0, 5);
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


}
