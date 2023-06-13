using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    private Dialoge dial;
    public Sprite[] bgs;
    public int bgNum;
    private RawImage rwIm;
    public static BackGround BG;

    public void Start()
    {
        dial = GetComponent<Dialoge>();
        rwIm = GetComponent<RawImage>();
        BG = this;
    }

    public void ChangeBG(int num)
    {
        rwIm.texture = bgs[num].texture;
        bgNum = num;
        if (bgNum == 3)
        {
            UI_Manager.ui.KitchenPl.SetActive(true);
        }
        else
        {
            UI_Manager.ui.KitchenPl.SetActive(false);
        }
    }
}
