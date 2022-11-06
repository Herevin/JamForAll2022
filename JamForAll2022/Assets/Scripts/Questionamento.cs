using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questionamento : MonoBehaviour
{
    [SerializeField] private GameObject perguntasGO;

    [HideInInspector] public Passageiro passageiro;


    public void AbrirQuestionamento()
    {
        perguntasGO.SetActive(true);
    }

    public void FecharQuestionamento()
    {
        perguntasGO.SetActive(false);
    }

    public void Time()
    {
        passageiro.RevelarTimeFutebol();
        FecharQuestionamento();
       
    }

    public void Pokemon()
    {
        passageiro.RevelarGeracaoPokemon();
        FecharQuestionamento();
    }

    public void Profissao()
    {
        passageiro.RevelarProfissao();
        FecharQuestionamento();
    }

    public void LOL()
    {
        passageiro.RevelarRoleLOL();
        FecharQuestionamento();
    }
}
