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


    void Start()
    {
        ui = this;
        Time.timeScale = 0;

    }

    public void OnStart()
    {
        Time.timeScale = 1;
        EventScript.eventScr.aud = Camera.main.GetComponent<AudioSource>();
        EventScript.eventScr.StartCoroutine("Events");
    }
}
