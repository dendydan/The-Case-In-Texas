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
    public Vector2 endpos;
    public bool isSpeaking;
    public string textRightNow;
    public RectTransform rect;
    public float alpha;

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
        spr.color = new Color(255, 255, 255, 0);
        alpha = 1;
    }

    public virtual void GoneTo(float localEndpos, int rotate, float startPosX, float startPosY)
    {
        rect.localPosition = new Vector2(startPosX, startPosY);
        endpos = new Vector2(localEndpos, startPosY);
        transform.DOLocalMoveX(localEndpos, 1);
        rect.localScale = new Vector3(rect.localScale.x * rotate, rect.localScale.y);
        spr.color = new Color(255, 255, 255, 1);
        alpha = 0;
    }

    public virtual void SetCharacterTo( int rotate, float startPosX, float startPosY)
    {
        rect.localPosition = new Vector2(startPosX, startPosY);
        endpos = new Vector2(startPosX, startPosY);
        rect.localScale = new Vector3(rect.localScale.x * rotate, rect.localScale.y);
        spr.color = new Color(255, 255, 255, 1);
        alpha = 1;
    }

    public virtual void SetCharacter(bool active)
    {
        child.SetActive(active);
        switch (active)
        {
            case true:
                spr.color = new Color(255, 255, 255, 1);
                alpha = 1;
                break;
            case false:
                spr.color = new Color(255, 255, 255, 0);
                alpha = 0;
                break;
        }
    }

    public virtual void Update()
    {
        spr.color = new Color(255, 255, 255, Mathf.Lerp(spr.color.a, alpha, 10 * Time.deltaTime));
        
        if (Input.GetMouseButtonDown(0) && Time.timeScale != 0 || Input.GetKeyDown(KeyCode.Space) && Time.timeScale != 0)
        {
            switch (istextAnimating)
            {
                case false:
                    isDialStart = false;
                    transform.DOKill();
                    rect.localPosition = endpos;
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
        spr.color = new Color(255, 255, 255, alpha);
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
}