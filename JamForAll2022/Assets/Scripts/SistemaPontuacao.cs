using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SistemaPontuacao : MonoBehaviour
{
    [SerializeField] private int pontosChefe = 50;
    [SerializeField] private int pontosPublico = 50;
    [SerializeField] private GameObject[] proximoPassageiro;
    [SerializeField] private Slider pontosChefeSlider;
    [SerializeField] private Slider pontosPublicoSlider;
    [SerializeField] private GameObject cobrancaGO;

    [SerializeField] private static int score;
    [SerializeField] private Text scoreText;

    public Passageiro passageiroExaminado;
    [SerializeField] RegrasChefe regras;

    //Idade              0
    //Altura             1
    //Destino            2
    //Foto               3
    //Time Futebol       4
    //Profissao          6
    //Geracao Pokemon    7
    //Role no LOL        8
    //Acessorio          9
    //Forma Pagamento    10
    //Quantia Dinheiro   11

    private void Start()
    {     
        pontosChefeSlider.value = (float)pontosChefe/100;
        pontosPublicoSlider.value = (float)pontosPublico/100;
        scoreText.text = score.ToString();
    }
    public void AceitarPassageiro()
    {
        if(regras.dinheiroParaPassagem  > passageiroExaminado.dinheiroParaPassagem)
        {
            AumentarDiminuirPontos(-15, 5);
            AumentarScore(15);
            Vector3 temp = passageiroExaminado.transform.position;
            Destroy(passageiroExaminado.gameObject);
            Instantiate(proximoPassageiro[Random.Range(0, proximoPassageiro.Length)], temp, Quaternion.identity);
            return;
        }

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
                        if (regras.idade < 45 ? regras.idade > passageiroExaminado.idade : regras.idade < passageiroExaminado.idade)
                        {
                            AumentarDiminuirPontos(-15, 5);
                            AumentarScore(15);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(10, 5); 
                        }
                        break;
                    case 1:
                        if (regras.altura < 1.7f ? regras.altura > passageiroExaminado.altura : regras.altura < passageiroExaminado.altura)
                        {
                            AumentarDiminuirPontos(-15, 5);
                            AumentarScore(15);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(10, 5);
                        }
                        break;
                    case 2:
                        if (regras.destino == passageiroExaminado.destino)
                        {
                            AumentarDiminuirPontos(-15, 5);
                            AumentarScore(15);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else AumentarDiminuirPontos(10, 5);

                        }

                        break;
                    case 3:
                        if (!passageiroExaminado.fotoCorresponde)
                        {
                            AumentarDiminuirPontos(-15, 5);
                            AumentarScore(15);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else AumentarDiminuirPontos(10, 5);
                        }
                        break;
                    case 4:
                        if (regras.timeFutebol == passageiroExaminado.timeFutebol)
                        {
                            AumentarDiminuirPontos(-15, 5);
                            AumentarScore(15);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else AumentarDiminuirPontos(10, 5);
                        }
                        break;
                    case 5:
                        if (regras.profissao == passageiroExaminado.profissao)
                        {
                            AumentarDiminuirPontos(-15, 5);
                            AumentarScore(15);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else AumentarDiminuirPontos(10, 5);
                        }
                        break;
                    case 6:
                        if (regras.geracaoPokemon == passageiroExaminado.geracaoPokemon)
                        {
                            AumentarDiminuirPontos(-15, 5);
                            AumentarScore(15);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else AumentarDiminuirPontos(10, 5);
                        }
                        break;
                    case 7:
                        if (regras.roleLOL == passageiroExaminado.roleLOL)
                        {
                            AumentarDiminuirPontos(-15, 5);
                            AumentarScore(15);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else AumentarDiminuirPontos(10, 5);
                        }
                        break;
                    case 8:
                        if (regras.acessorios == passageiroExaminado.acessorios && !passageiroExaminado.naoPossuiAcc)
                        {
                            AumentarDiminuirPontos(-15, 5);
                            AumentarScore(15);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1)
                            {
                                quantidadeRegras -= 1;
                                break;
                            }
                            else AumentarDiminuirPontos(10, 5);
                        }
                        break;
                  
                }
            }
        }
        
        AumentarScore(45);
        
        Vector3 posicao = passageiroExaminado.transform.position;
        Destroy(passageiroExaminado.gameObject);
        Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], posicao, Quaternion.identity);



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
                        if (regras.idade < 45 ? regras.idade > passageiroExaminado.idade : regras.idade < passageiroExaminado.idade)
                        {
                            AumentarDiminuirPontos(5, -5);
                            AumentarScore(45);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(-5, -5);
                        }
                        break;
                    case 1:
                        if (regras.altura < 1.7f ? regras.altura > passageiroExaminado.altura : regras.altura < passageiroExaminado.altura)
                        {
                            AumentarDiminuirPontos(5, -5);
                            AumentarScore(45);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(-5, -5);
                        }
                        break;
                    case 2:
                        if (regras.destino == passageiroExaminado.destino)
                        {
                            AumentarDiminuirPontos(5, -5);
                            AumentarScore(45);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(-5, -5);
                        }


                        break;
                    case 3:
                        if (!passageiroExaminado.fotoCorresponde)
                        {
                            AumentarDiminuirPontos(5, -5);
                            AumentarScore(45);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(-5, -5);
                        }
                        break;
                    case 4:
                        if (regras.timeFutebol == passageiroExaminado.timeFutebol)
                        {
                            AumentarDiminuirPontos(5, -5);
                            AumentarScore(45);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(-5, -5);
                        }
                        break;
                    case 5:
                        if (regras.profissao == passageiroExaminado.profissao)
                        {
                            AumentarDiminuirPontos(5, -5);
                            AumentarScore(45);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(-5, -5);
                        }
                        break;
                    case 6:
                        if (regras.geracaoPokemon == passageiroExaminado.geracaoPokemon)
                        {
                            AumentarDiminuirPontos(5, -5);
                            AumentarScore(45);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(-5, -5);
                        }
                        break;
                    case 7:
                        if (regras.roleLOL == passageiroExaminado.roleLOL)
                        {
                            AumentarDiminuirPontos(5, -5);
                            AumentarScore(45);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(-5, -5);
                        }
                        break;
                    case 8:
                        if (regras.acessorios == passageiroExaminado.acessorios)
                        {
                            AumentarDiminuirPontos(5, -5);
                            AumentarScore(45);
                            Vector3 temp = passageiroExaminado.transform.position;
                            Destroy(passageiroExaminado.gameObject);
                            Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], temp, Quaternion.identity);
                            return;
                        }
                        else
                        {
                            if (quantidadeRegras > 1) quantidadeRegras -= 1;
                            else AumentarDiminuirPontos(-5, -5);
                        }
                        break;
                   
                }
            }
        }
        AumentarScore(15);
        Vector3 posicao = passageiroExaminado.transform.position;
        Destroy(passageiroExaminado.gameObject);
        Instantiate(proximoPassageiro[Random.Range(0,proximoPassageiro.Length)], posicao, Quaternion.identity);
    }


    public void CobrarDinheiro()
    {
        cobrancaGO.SetActive(true);
        cobrancaGO.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "x" + passageiroExaminado.moedasInt;
        cobrancaGO.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "x" + passageiroExaminado.moedasMei;
    }

    public void FecharCobran�a()
    {
        cobrancaGO.SetActive(false);
    }

    public void AumentarDiminuirPontos(int pChefe, int pPublico)
    {
        if (pontosChefe + pChefe < 100) pontosChefe += pChefe;
        else if (pontosChefe + pChefe > 100) pontosChefe = 100;
        if (pontosPublico + pPublico < 100) pontosPublico += pPublico;
        else if (pontosPublico + pPublico > 100) pontosPublico = 100;

        pontosChefeSlider.value = (float)pontosChefe/100;
        pontosPublicoSlider.value = (float)pontosPublico/100;
    }

    public void AumentarScore(int scoreGained) {
        score += scoreGained;
        scoreText.text = score.ToString();
    }
   

}
