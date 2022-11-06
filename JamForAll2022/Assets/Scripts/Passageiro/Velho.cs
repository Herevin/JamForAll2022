using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Velho : Passageiro
{
    //0 - Oculos
    //1 - Brinco
    //2 - Chapéu
    //3 - Colar
    //4 - Piercing = Nada




    void Start()
    {
        mySR = GetComponent<SpriteRenderer>();
        idade = Random.Range(60, 90);
        altura = Random.Range(1.55f, 1.75f);
        altura = Mathf.Round(altura * 100.0f) * 0.01f;
        destino = (Destino)Random.Range(0, 5);
        timeFutebol = (TimeFutebol)Random.Range(0, 5);
        profissao = (Profissao)Random.Range(0, 5);
        geracaoPokemon = (GeracaoPokemon)Random.Range(0, 8);
        roleLOL = (RoleLOL)Random.Range(0, 5);
        acessorios = (Acessorios)Random.Range(0, 5);
        switch (acessorios)
        {
            case Acessorios.Óculos:
                mySR.sprite = mySpriteVariants[0];
                mySprite = mySR.sprite;
                naoPossuiAcc = true;

                break;
            case Acessorios.Brinco:
                mySR.sprite = mySpriteVariants[1];
                mySprite = mySR.sprite;

                break;
            case Acessorios.Chapéu:
                mySR.sprite = mySpriteVariants[2];
                mySprite = mySR.sprite;
                naoPossuiAcc = true;

                break;
            case Acessorios.Colar:
                mySR.sprite = mySpriteVariants[3];
                mySprite = mySR.sprite;

                break;
            case Acessorios.Piercing:
                mySR.sprite = mySpriteVariants[4];
                mySprite = mySR.sprite;
              

                break;
        }

        int foto = Random.Range(0, 3);
        if (foto == 0)
        {
            fotoCorresponde = false;
        }
        if (foto >= 1)
        {
            fotoCorresponde = true;

        }


        tipoPagamento = (TipoPagamento)Random.Range(0, 2);
        if (tipoPagamento == TipoPagamento.Dinheiro) dinheiroParaPassagem = Random.Range(7.5f, 10f);
        dinheiroParaPassagem = Mathf.Round(dinheiroParaPassagem * 100.0f) * 0.01f;


        ficha = GameObject.Find("InformacoesFicha");
        ficha.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Idade" + "\n" + idade.ToString();
        ficha.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "Altura" + "\n" + altura.ToString();
        ficha.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = "Destino" + "\n" + destino.ToString();
        ficha.transform.GetChild(4).GetComponent<SpriteRenderer>().sprite = fotoCorresponde ? mySprite : wrongSprite[Random.Range(0, wrongSprite.Length)];
        ficha.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = "";
        ficha.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = "";
        ficha.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = "";
        ficha.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = "";
        if (!naoPossuiAcc) ficha.transform.GetChild(9).GetComponent<TextMeshProUGUI>().text = "Acessorios" + "\n" + acessorios.ToString();
        if (naoPossuiAcc) ficha.transform.GetChild(9).GetComponent<TextMeshProUGUI>().text = "Acessorios" + "\n" + "Nenhum";


        GameObject.FindObjectOfType<SistemaPontuacao>().passageiroExaminado = this;
        GameObject.FindObjectOfType<Questionamento>().passageiro = this;



    }


}
