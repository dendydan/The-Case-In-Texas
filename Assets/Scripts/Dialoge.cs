using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public abstract class Dialoge : MonoBehaviour
{
    public bool istextAnimating;
    public bool isDialStart;
    public string CharName;
    public static Dialoge dial;
    public GameObject child;
    private RawImage spr;
    private float i;

    public void Start()
    {
        dial = this;
        spr = child.GetComponent<RawImage>();
    }

    public virtual void MoveToOn(float endpos, float duration , int rotate , float startPosX ,float startPosY)
    { 
        transform.GetComponent<RectTransform>().localPosition = new Vector2(startPosX, startPosY);
        transform.DOLocalMoveX(endpos, duration);
        transform.GetComponent<RectTransform>().localScale = new Vector3(transform.GetComponent<RectTransform>().localScale.x * rotate, transform.GetComponent<RectTransform>().localScale.y);
    }

    public void SetCharacter(bool active)
    {
        child.SetActive(active);
    }

    public virtual void SetCharPos(float x, float y)
    {
        transform.GetComponent<RectTransform>().localPosition = new Vector2(x, y);
    }

    public virtual void Update()
    {
        //spr.color = new Color(255, 255, 255, i);
        if (Input.GetMouseButtonDown(0) && Time.timeScale !=0 || Input.GetKeyDown(KeyCode.Space) && Time.timeScale != 0)
        {
            if (istextAnimating == false)
            {
                isDialStart = false;
            }
            else
            {
                return;
            //    StopDialoge();
            }
        }
    }

    public virtual void Say(string text)
    {
        StartDialoge(text);
    }

    //public virtual void StopDialoge()
    //{
    //    StopCoroutine("AnimText");
    //    UI_Manager.ui.dialogeText.text = ;
    //    istextAnimating = false;
    //    isDialStart = true;
    //}

    public virtual void StartDialoge(string text)
    {
        UI_Manager.ui.dialogeText.text = "";
        UI_Manager.ui.Name.text = CharName;
        StartCoroutine("AnimText", text);;
        isDialStart = true;
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

    //public virtual IEnumerator Lerp(bool isComes)
    //{
    //    if (isComes == true)
    //    {
    //        spr.color = new Color(255, 255, 255, 0);
    //        i = 0f;
    //        while (i < 1f)
    //        {
    //            yield return new WaitForSeconds(0.00001f);
    //            i += 0.05f;
    //            yield return i;
    //        }
    //    }
    //    else
    //    {
    //        spr.color = new Color(255, 255, 255, 255);
    //        i = 1f;
    //        while (i > 1f)
    //        {
    //            yield return new WaitForSeconds(0.00001f);
    //            i -= 0.05f;
    //            yield return i;
    //        }
    //    }

    //}
}