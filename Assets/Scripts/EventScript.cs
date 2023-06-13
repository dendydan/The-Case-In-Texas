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
        reader.Say("Одним прекрасным днём, когда забегаловка только открылась. Стояла отличная погода, хоть и на улице все еще была весна, выглядело так, как будто только начинается лето, хотя для техасского климата это вполне нормально, ибо почти везде пустыня.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("Вскоре после открытия забегаловки, нахлынул прилив добровольцев, которые хотели устроиться на работу.");
        BackGround.BG.ChangeBG(1);
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("это были Черр, Мухтар и Луп.");
        muhtar.SetCharPos(0, -134);
        muhtar.SetCharacter(true);
        cher.SetCharPos(-573, -331);
        cher.SetCharacter(true);
        lup.SetCharPos(605, -94);
        lup.SetCharacter(true);
        BackGround.BG.ChangeBG(2);
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say(" Черр уже давно стоял у плиты и делал свои дела.");
        BackGround.BG.ChangeBG(3);
        lup.SetCharacter(false);
        muhtar.SetCharacter(false);
        cher.SetCharPos(0, -10);
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("А Мухтар с лупом стояли в столовой, ожидая пока прийдёт менеджер или кто-то другой, и вот, вскоре он пришёл.");
        muhtar.SetCharPos(0, -134);
        muhtar.SetCharacter(true);
        cher.SetCharacter(false);
        lup.SetCharPos(605, -94);
        lup.SetCharacter(true);
        BackGround.BG.ChangeBG(2);
        yield return new WaitUntil(() => reader.isDialStart == false);
        kote.SetCharacter(true);
        kote.MoveToOn(-656f, 1, -1, -1240, -60);
        kote.Say("— Здравствуйте!");
        yield return new WaitUntil(() => kote.isDialStart == false);
        reader.Say("Cказал Кот, увидев обоих персон, заряженных потенциалом к работе.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        muhtar.Say("— Чзх?! Почему он летает?!!!");
        yield return new WaitUntil(() => muhtar.isDialStart == false);
        reader.Say("Прошептал он Лупу.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        lup.Say("— я сам в ахуе если честно...");
        yield return new WaitUntil(() => lup.isDialStart == false);
        reader.Say("Ответил тот.");
        yield return new WaitUntil(() => reader.isDialStart == false); //Оптимизируйте если вам угодно
        reader.Say("Им провели небольшую беседу");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("Затем он ушли на кухню, где им сказали делать донеры.");
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
        reader.Say("На кухню зашла госпожа Сено, как ни странно это был стог сена, по её виду можно была сказать что зрение у неё оставляет желать лучшего, отчего она носит очки.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("Вид у госпожи Сено был странный.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("Будто вот-вот что-то произойдет от чего она нервничает.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("Но затем она сказала:");
        yield return new WaitUntil(() => reader.isDialStart == false);
        seno.Say("Котэ, нам нужно срочно выйти!~");
        yield return new WaitUntil(() => seno.isDialStart == false);
        kote.Say("Хорошо, я скоро приду!");
        yield return new WaitUntil(() => kote.isDialStart == false);
        seno.MoveToOn(-1280, 3, -1, -671, -105);
        reader.Say("Сено стремительно вышла.");
        yield return new WaitUntil(() => reader.isDialStart == false);
        kote.Say("А вы не расслабляйтесь! Чтобы когда пришел все было готово!");
        kote.MoveToOn(-149, 3, 1, -149, -60);
        yield return new WaitUntil(() => kote.isDialStart == false);
        kote.MoveToOn(-1500f, 3, 1, -656, -60);
        reader.Say("Котэ вышел спеша за Сено");
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
            kote.Say("ЫЫЫЫЫЫЫЫ ЧЛЕНЫ");
        }
        else
        {
            kote.Say("Что такое?");
        }
        yield return new WaitUntil(() => kote.isDialStart == false);
        seno.Say("Ну вообщем...");
        yield return new WaitUntil(() => seno.isDialStart == false);
        seno.Say("ээээээ.....");
        yield return new WaitUntil(() => seno.isDialStart == false);
        seno.Say("Короче, блять");
        yield return new WaitUntil(() => seno.isDialStart == false);
        BackGround.BG.GetComponent<RawImage>().color = Color.black;
        seno.SetCharacter(false);
        kote.SetCharacter(false);
        aud.PlayOneShot(chmok);
        reader.Say("Вас поцеловали");
        yield return new WaitForSeconds(1);
        BackGround.BG.GetComponent<RawImage>().color = Color.white;
        seno.SetCharacter(true);
        kote.SetCharacter(true);
        seno.MoveToOn(-1500, 1, 1, 535, -105);
        reader.Say("От дикого смущения сено убежала прочь");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("Это было странное чувство, вы его еще запомните надолго");
        yield return new WaitUntil(() => reader.isDialStart == false);


        BackGround.BG.GetComponent<RawImage>().color = Color.black;
        seno.SetCharacter(false);
        kote.SetCharacter(false);
        reader.CharName = "Автор";
        reader.Say("Или нет!");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("Потому что я заебался программировать эту залупу");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("ОГРОМНОЕ СПАСИБО Дмитруку за предоставленный сюжет, без тебя этого бы небыло!");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("Если вы захотите помочь с проектом, то все исходники я оставлю в своем форуме на сервере Котэ!");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("Спасибо, что потратили своё время на эту херню");
        yield return new WaitUntil(() => reader.isDialStart == false);
        reader.Say("Если найдёте какие-либо баги пишите в форуме отметив меня. ПОКА!");
        yield return new WaitForSeconds(10);
        Application.Quit();

    }
}
