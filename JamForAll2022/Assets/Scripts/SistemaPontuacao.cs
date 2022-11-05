using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPontuacao : MonoBehaviour
{
    [SerializeField] private int pontosChefe = 50;
    [SerializeField] private int pontosPublico = 50;
    [SerializeField] private GameObject proximoPassageiro;

    public Passageiro passageiroExaminado;
    [SerializeField]RegrasChefe regras;

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


    public void AceitarPassageiro()
    {
        int quantidadeRegras = 0;
        for (int i = 0; i < regras.avaliacoes.Length; i++)
        {
            if (regras.avaliacoes[i]) quantidadeRegras += 1;


        }


        for (int i = 0; i < regras.avaliacoes.Length; i++)
            {
            if (regras.avaliacoes[i])
            {
                switch (i)
                {
                    case 0:
                        if (regras.idade < 45 ? regras.idade > passageiroExaminado.idade: regras.idade < passageiroExaminado.idade)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else Debug.Log("ERROU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 1:
                        if (regras.altura < 1.7f ? regras.altura > passageiroExaminado.altura : regras.altura < passageiroExaminado.altura)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else Debug.Log("ERROU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 2:
                        if (regras.tipoPagamento == passageiroExaminado.tipoPagamento)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");

                        }

                        break;
                    case 3:
                        if (regras.tipoPagamento < passageiroExaminado.tipoPagamento)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 4:
                        if (regras.corRoupa == passageiroExaminado.corRoupa)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 5:
                        if (regras.timeFutebol == passageiroExaminado.timeFutebol)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 6:
                        if (regras.profissao == passageiroExaminado.profissao)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 7:
                        if (regras.geracaoPokemon == passageiroExaminado.geracaoPokemon)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 8:
                        if (regras.roleLOL == passageiroExaminado.roleLOL)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 9:
                        if (regras.corCabelo == passageiroExaminado.corCabelo)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }

                        break;
                    case 10:
                        if (regras.acessorios == passageiroExaminado.acessorios)
                        {
                            Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }
                        break;

                }
            }
        }
        Vector3 posicao = passageiroExaminado.transform.position;
        Destroy(passageiroExaminado.gameObject);
        Instantiate(proximoPassageiro,posicao,Quaternion.identity);



    }

    public void RejeitarPassageiro()
    {
        int quantidadeRegras = 0;
        for (int i = 0; i < regras.avaliacoes.Length; i++)
        {
            if (regras.avaliacoes[i]) quantidadeRegras += 1;


        }


        for (int i = 0; i < regras.avaliacoes.Length; i++)
        {
            if (regras.avaliacoes[i])
            {
                switch (i)
                {
                    case 0:
                        if (regras.idade < 45 ? regras.idade  > passageiroExaminado.idade : regras.idade < passageiroExaminado.idade)
                        {
                            Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 1:
                        if (regras.altura < 1.7f ? regras.altura > passageiroExaminado.altura : regras.altura < passageiroExaminado.altura)
                        {
                            Debug.Log("ACERTOU MANO -5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else Debug.Log("ERROU MANO +5 PONTOS COM O CHEFIA && +5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 2:
                        if (regras.tipoPagamento == passageiroExaminado.tipoPagamento)
                        {
                            Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else  Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                        }


                        break;
                    case 3:
                        if (regras.tipoPagamento < passageiroExaminado.tipoPagamento)
                        {
                            Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else  Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 4:
                        if (regras.corRoupa == passageiroExaminado.corRoupa)
                        {
                            Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 5:
                        if (regras.timeFutebol == passageiroExaminado.timeFutebol)
                        {
                            Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 6:
                        if (regras.profissao == passageiroExaminado.profissao)
                        {
                            Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else  Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 7:
                        if (regras.geracaoPokemon == passageiroExaminado.geracaoPokemon)
                        {
                            Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 8:
                        if (regras.roleLOL == passageiroExaminado.roleLOL)
                        {
                            Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                        }
                        break;
                    case 9:
                        if (regras.corCabelo == passageiroExaminado.corCabelo)
                        {
                            Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                        }

                        break;
                    case 10:
                        if (regras.acessorios == passageiroExaminado.acessorios)
                        {
                            Debug.Log("ACERTOU MANO +5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro, temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else  Debug.Log("ERROU MANO -5 PONTOS COM O CHEFIA && -5 PONTOS COM O PUBLICO");
                        }
                        break;

                }
            }
        }
        Vector3 posicao = passageiroExaminado.transform.position;
        Destroy(passageiroExaminado.gameObject);
        Instantiate(proximoPassageiro, posicao, Quaternion.identity);
    }

   

}
