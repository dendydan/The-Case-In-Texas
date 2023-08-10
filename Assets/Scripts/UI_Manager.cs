using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager ui;
    public TMP_Text dialogeText;
    public GameObject dialogeFrame;
    public TMP_Text Name;
    public RawImage bg;
    public GameObject KitchenPl;
    public Dialoge[] characters;
    public int choise = -1;
    public bool isChoiseSetting;
    public TMP_Text context;
    public TMP_Text choiseOne;
    public TMP_Text choiseTwo;
    public GameObject choiseGM;


    void Start()
    {
        ui = this;
        Time.timeScale = 0;

    }

    public void SetChoiseGM(bool active)
    {
        choiseGM.SetActive(active);
    }

    public void SetChoiseNum(int choiseNum)
    {
        choise = choiseNum;
    }

    public void SetChoise(string localContext, string localChoiseOne, string localChoiseTwo)
    {
        context.text = localContext;
        choiseOne.text = localChoiseOne;
        choiseTwo.text = localChoiseTwo;
    }

    public void AfterChoise()
    {
        isChoiseSetting = false;
    }

    public void OnStart()
    {
        Time.timeScale = 1;
        EventScript.eventScr.aud = Camera.main.GetComponent<AudioSource>();
        EventScript.eventScr.StartCoroutine("Events");
    }
}
