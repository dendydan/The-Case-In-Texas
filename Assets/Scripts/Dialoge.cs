using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public abstract class Dialoge : MonoBehaviour
{
    public bool istextAnimating;
    public bool isDialStart = true;
    public string CharName;
    public GameObject child;
    public RawImage spr;
    public float i = 255f;
    public Vector2 endpos;
    public bool isSpeaking;
    public string textRightNow;
    public RectTransform rect;
    public bool isCame;

    public virtual void Start()
    {
        spr = child.GetComponent<RawImage>();
    }

    public virtual void ComeTo(float localEndpos, int rotate, float startPosX, float startPosY)
    {
        rect.localPosition = new Vector2(startPosX, startPosY);
        endpos = new Vector2(localEndpos, startPosY);
        transform.DOLocalMoveX(localEndpos, 1);
        rect.localScale = new Vector3(rect.localScale.x * rotate, rect.localScale.y);
        StartCoroutine("LerpOn");
        isCame = true;
    }

    public virtual void SetCharacterTo( int rotate, float startPosX, float startPosY)
    {
        i = 1;
        rect.localPosition = new Vector2(startPosX, startPosY);
        endpos = new Vector2(startPosX, startPosY);
        rect.localScale = new Vector3(rect.localScale.x * rotate, rect.localScale.y);
        isCame = true;
    }

    public virtual void GoneTo(float localEndpos, int rotate, float startPosX, float startPosY)
    {
        rect.localPosition = new Vector2(startPosX, startPosY);
        transform.DOLocalMoveX(localEndpos, 1);
        rect.localScale = new Vector3(rect.localScale.x * rotate, rect.localScale.y);
        StartCoroutine("LerpOff");
        isCame = false;
    }

    public virtual void SetCharacter(bool active)
    {
        child.SetActive(active);
        switch (active)
        {
            case true:
                i = 1;
                break;
            case false:
                i = 0;
                break;
        }
    }

    public virtual void Update()
    {
        spr.color = new Color(255, 255, 255, i);
        if (/*Input.GetMouseButtonDown(0) && Time.timeScale != 0 || */Input.GetKeyDown(KeyCode.Space) && Time.timeScale != 0)
        {
            switch (istextAnimating)
            {
                case false:
                    isDialStart = false;
                    transform.DOKill();
                    rect.localPosition = endpos;
                    if(isCame == true)
                    {
                        i = 1;
                    }
                    else
                    {
                        i = 0;
                    }
                    break;

                case true:
                    Stop();
                    break;
            }
        }
    }

    public virtual void Say(string text)
    {
        textRightNow = text;
        UI_Manager.ui.dialogeText.text = "";
        UI_Manager.ui.Name.text = CharName;
        StartCoroutine("AnimText", text); ;
        isDialStart = true;
    }

    public void Stop()
    {
        Debug.Log(CharName + " " + endpos);
        StopCoroutine("AnimText");
        transform.DOKill();
        rect.localPosition = endpos;
        UI_Manager.ui.dialogeText.text = textRightNow;
        istextAnimating = false;
    }

    public virtual IEnumerator AnimText(string textAnim)
    {
        foreach (char ch in textAnim)
        {
            yield return new WaitForSeconds(0.05f);
            UI_Manager.ui.dialogeText.text = UI_Manager.ui.dialogeText.text.Insert(UI_Manager.ui.dialogeText.text.Length, ch.ToString());
            //Insert - вставляет [в опр. позицию в тексте](1) [кусок текста](2)
            istextAnimating = true;
        }
        istextAnimating = false;
    }



    public virtual IEnumerator LerpOn()
    {
        spr.color = new Color(255, 255, 255, 0);
        i = 0f;
        while (i < 1f)
        {
            yield return new WaitForSeconds(0.00001f);
            i += 0.05f;
        }
    }

    public virtual IEnumerator LerpOff()
    {
        spr.color = new Color(255, 255, 255, 255);
        i = 1f;
        while (i > 0)
        {
            yield return new WaitForSeconds(0.00001f);
            i -= 0.05f;
        }
    }
}