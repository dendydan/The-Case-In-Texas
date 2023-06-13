using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventScript : MonoBehaviour
{
    public Sprite[] bgs;
    public MuhtarDialoge muhtar;
    public CherDialoge cher;
    public ReaderDialoge reader;
    public LupDialoge lup;
    public KoteDialoge kote;
    public SenoDialoge seno;
    public string text;
    public static EventScript eventScr;
    public AudioClip chmok;
    public AudioSource aud;

    public void Start()
    {
        eventScr = this;
    }

    public IEnumerator Events()
    {
        reader.Say("����� ���������� ���, ����� ����������� ������ ���������. ������ �������� ������, ���� � �� ����� ��� ��� ���� �����, ��������� ���, ��� ����� ������ ���������� ����, ���� ��� ���������� ������� ��� ������ ���������, ��� ����� ����� �������.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("������ ����� �������� �����������, �������� ������ ������������, ������� ������ ���������� �� ������.");
        BackGround.BG.ChangeBG(1);
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("��� ���� ����, ������ � ���.");
        muhtar.SetCharPos(0, -134);
        muhtar.SetCharacter(true);
        cher.SetCharPos(-573, -331);
        cher.SetCharacter(true);
        lup.SetCharPos(605, -94);
        lup.SetCharacter(true);
        BackGround.BG.ChangeBG(2);
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say(" ���� ��� ����� ����� � ����� � ����� ���� ����.");
        BackGround.BG.ChangeBG(3);
        lup.SetCharacter(false);
        muhtar.SetCharacter(false);
        cher.SetCharPos(0, -10);
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("� ������ � ����� ������ � ��������, ������ ���� ������ �������� ��� ���-�� ������, � ���, ������ �� ������.");
        muhtar.SetCharPos(0, -134);
        muhtar.SetCharacter(true);
        cher.SetCharacter(false);
        lup.SetCharPos(605, -94);
        lup.SetCharacter(true);
        BackGround.BG.ChangeBG(2);
        yield return new WaitUntil(() => reader.isDialStart == false);
        kote.SetCharacter(true);
        kote.MoveToOn(-656f, 1, -1, -1240, -60);
        kote.Say("� ������������!");
        yield return new WaitUntil(() => kote.isDialStart == false);
        reader.Say("C����� ���, ������ ����� ������, ���������� ����������� � ������.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        muhtar.Say("� ���?! ������ �� ������?!!!");
        yield return new WaitUntil(() => muhtar.isDialStart == false);
        reader.Say("��������� �� ����.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        lup.Say("� � ��� � ���� ���� ������...");
        yield return new WaitUntil(() => lup.isDialStart == false);
        reader.Say("������� ���.");
        yield return new WaitUntil(() => reader.isDialStart == false); //������������� ���� ��� ������
        reader.Say("�� ������� ��������� ������");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("����� �� ���� �� �����, ��� �� ������� ������ ������.");
        kote.MoveToOn(-1500f, 3, -1, -656, -60);
        lup.MoveToOn(-1500f, 3, -1, 605f, -94);
        muhtar.MoveToOn(-1500f, 3, -1, 0f, 0);
        yield return new WaitForSeconds(3);
        BackGround.BG.ChangeBG(3);
        kote.MoveToOn(-149, 3, -1, 1500, -60);
        lup.MoveToOn(787, 3, -1, 1500, -94);
        muhtar.MoveToOn(341, 3, -1, 1500, 0);
        yield return new WaitForSeconds(2.5f);
        seno.SetCharacter(true);
        seno.MoveToOn(-671, 3, 1, -1240, -105);
        reader.Say("�� ����� ����� ������� ����, ��� �� ������� ��� ��� ���� ����, �� � ���� ����� ���� ������� ��� ������ � �� ��������� ������ �������, ������ ��� ����� ����.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("��� � ������� ���� ��� ��������.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("����� ���-��� ���-�� ���������� �� ���� ��� ����������.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("�� ����� ��� �������:");
        yield return new WaitUntil(() => reader.isDialStart == false);
        seno.Say("����, ��� ����� ������ �����!~");
        yield return new WaitUntil(() => seno.isDialStart == false);
        kote.Say("������, � ����� �����!");
        yield return new WaitUntil(() => kote.isDialStart == false);
        seno.MoveToOn(-1280, 3, -1, -671, -105);
        reader.Say("���� ������������ �����.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        kote.Say("� �� �� ��������������! ����� ����� ������ ��� ���� ������!");
        kote.MoveToOn(-149, 3, 1, -149, -60);
        yield return new WaitUntil(() => kote.isDialStart == false);
        kote.MoveToOn(-1500f, 3, 1, -656, -60);
        reader.Say("���� ����� ����� �� ����");
        yield return new WaitUntil(() => reader.isDialStart == false);
        muhtar.SetCharacter(false);
        lup.SetCharacter(false);
        BackGround.BG.ChangeBG(4);
        kote.MoveToOn(-75, 1, 1, -1500, -60);
        seno.MoveToOn(535, 0, 1, 535, -105);
        reader.Say("");
        yield return new WaitForSeconds(2);
        if (Input.GetKeyDown(KeyCode.E))
        {
            kote.Say("�������� �����");
        }
        else
        {
            kote.Say("��� �����?");
        }
        yield return new WaitUntil(() => kote.isDialStart == false);
        seno.Say("�� �������...");
        yield return new WaitUntil(() => seno.isDialStart == false);
        seno.Say("������.....");
        yield return new WaitUntil(() => seno.isDialStart == false);
        seno.Say("������, �����");
        yield return new WaitUntil(() => seno.isDialStart == false);
        BackGround.BG.GetComponent<RawImage>().color = Color.black;
        seno.SetCharacter(false);
        kote.SetCharacter(false);
        aud.PlayOneShot(chmok);
        reader.Say("��� ����������");
        yield return new WaitForSeconds(1);
        BackGround.BG.GetComponent<RawImage>().color = Color.white;
        seno.SetCharacter(true);
        kote.SetCharacter(true);
        seno.MoveToOn(-1500, 1, 1, 535, -105);
        reader.Say("�� ������ �������� ���� ������� �����");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("��� ���� �������� �������, �� ��� ��� ��������� �������");
        yield return new WaitUntil(() => reader.isDialStart == false);


        BackGround.BG.GetComponent<RawImage>().color = Color.black;
        seno.SetCharacter(false);
        kote.SetCharacter(false);
        reader.CharName = "�����";
        reader.Say("��� ���!");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("������ ��� � �������� ��������������� ��� ������");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("�������� ������� �������� �� ��������������� �����, ��� ���� ����� �� ������!");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("���� �� �������� ������ � ��������, �� ��� ��������� � ������� � ����� ������ �� ������� ����!");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("�������, ��� ��������� ��� ����� �� ��� �����");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("���� ������ �����-���� ���� ������ � ������ ������� ����. ����!");
        yield return new WaitForSeconds(10);
        Application.Quit();

    }
}
