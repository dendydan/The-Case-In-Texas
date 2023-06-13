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
        reader.Say("H������ �� ������ ����� ������ �����. ����� ���������� ����� ����� ������� �� ������.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("����� ���������� ���, ����� ����������� ������ ���������. ������ �������� ������, ���� � �� ����� ��� ��� ���� �����, ��������� ���, ��� ����� ������ ���������� ����, ���� ��� ���������� ������� ��� ������ ���������, ��� ����� ����� �������.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("������ ����� �������� �����������, �������� ������ ������������, ������� ������ ���������� �� ������.");
        BackGround.BG.ChangeBG(1);
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("��� ���� ����, ������ � ���.");
        muhtar.SetCharacterTo(1, 0, -134);
        muhtar.SetCharacter(true);
        cher.SetCharacterTo(1, -573, -331);
        cher.SetCharacter(true);
        lup.SetCharacterTo(1 , 605, -134);
        lup.SetCharacter(true);
        BackGround.BG.ChangeBG(2);
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say(" ���� ��� ����� ����� � ����� � ����� ���� ����.");
        BackGround.BG.ChangeBG(3);
        lup.SetCharacter(false);
        muhtar.SetCharacter(false);
        cher.SetCharacterTo(1, 0, -10);
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("� ������ � ����� ������ � ��������, ������ ���� ������ �������� ��� ���-�� ������, � ���, ������ �� ������.");
        muhtar.SetCharacterTo(1, 0, -134);
        muhtar.SetCharacter(true);
        cher.SetCharacter(false);
        lup.SetCharacterTo(1, 605, -134);
        lup.SetCharacter(true);
        BackGround.BG.ChangeBG(2);
        yield return new WaitUntil(() => reader.isDialStart == false);
        kote.SetCharacter(true);
        kote.ComeTo(-656f, -1, -1240, -223);
        kote.Say("� ������������!");
        yield return new WaitUntil(() => kote.isDialStart == false);
        reader.Say("C����� ���, ������ ����� ������, ���������� ����������� � ������.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        muhtar.Say("� ���?! ������ �� ��(��. ������� ����) ������?!!!");
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
        kote.GoneTo(-1240f, -1, -656, -223);
        lup.GoneTo(-1240f, -1, 605f, -132);
        muhtar.GoneTo(-1240f, -1, 0f, -132);
        yield return new WaitForSeconds(3);
        BackGround.BG.ChangeBG(3);
        kote.ComeTo(-149, -1, 1240, -223);
        lup.ComeTo(787, -1, 1240, -132);
        muhtar.ComeTo(341, -1, 1240, -132);
        yield return new WaitForSeconds(2.5f);
        seno.SetCharacter(true);
        seno.ComeTo(-671, 1, -1240, -105);
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
        seno.GoneTo(-1280, -1, -671, -105);
        reader.Say("���� ������������ �����.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        kote.Say("� �� �� ��������������! ����� ����� ������ ��� ���� ������!");
        yield return new WaitUntil(() => kote.isDialStart == false);
        kote.ComeTo(-1500f, 1, -149, -132);
        reader.Say("���� ����� ����� �� ����");
        yield return new WaitUntil(() => reader.isDialStart == false);
        muhtar.SetCharacter(false);
        lup.SetCharacter(false);
        BackGround.BG.ChangeBG(4);
        kote.ComeTo(-75, 1, -1500, -60);
        seno.SetCharacterTo(1, 535, -105);
        reader.Say("");
        yield return new WaitForSeconds(2);
        kote.Say("��� �����?");
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
        seno.GoneTo(-1500, 1, 535, -105);
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
        reader.Say("� �� ��� ����� �...");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("�������� ������� �������� �� ��������������� �����, ��� ���� ����� �� ������! � ���-�� ������� ���� �� ��������� ����� �� ���� �������");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("���� �� �������� ������ � ��������, �� ��� ��������� � ������� � ����� ������, � ����� ��� � ��������� ������ �� ������� ����!");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("�������, ��� ��������� ��� ����� �� ��� �����");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("� � �����. ������-��� �� ������ ���������������� ������ 2:11(���) ����� ����...");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("���� ������ �����-���� ���� ������ � ������/������ ������� ����. ����!");
        yield return new WaitForSeconds(10);
        Application.Quit();
    }
}
