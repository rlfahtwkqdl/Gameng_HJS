using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    public int gold = 100;
    public int potion = 3;

    public int attack = 10;  // 필드
    int killCount = 0;       // 필드


    
    [ContextMenu("나 김두한이다")]
    void Hello()
    {
        Debug.Log("나 김두한이다");
    }

    [ContextMenu("뭣 김두한?")]
    void Test1()
    {
        int hp = 10;
        Debug.Log(hp);
    }

    [ContextMenu("아편이야 아편")]
    void ShowGold()
    {
        Debug.Log(gold);
    }

    [ContextMenu("무빙 1")]
    void Predict1()
    {
        int hp = 10;
        hp = hp - 3;
        Debug.Log(hp);
        hp = 20;
        Debug.Log(hp);
        int maxHp = hp;
        hp = 5;
        Debug.Log(maxHp);
    }

     [ContextMenu("무빙 2")]
    void Predict2()
    {
        int hp = 7;
        int maxHp = 10;
        Debug.Log(hp / maxHp);
        Debug.Log((float)hp / maxHp);
        Debug.Log(hp / 2);
        Debug.Log(hp / 2f);
        Debug.Log(hp % 2);
    }

     [ContextMenu("무빙 3")]
    void Predict3()
    {
        int a = 1;
        int b = 2;
        Debug.Log("합: " + a + b);
        Debug.Log("합: " + (a + b));
        Debug.Log(a + b + "점");
        Debug.Log("HP " + 7 / 2);
    }




    [ContextMenu("호두 따기")]
    void CountKill()
    {
        int defense = 3;     // 지역 변수
        killCount = killCount + 2;
        Debug.Log(attack - defense);
        Debug.Log(killCount);
    }

     [ContextMenu("영사기 폭8")]
    void Overflow()
    {
        int gold = int.MaxValue;
        Debug.Log(gold);
        gold = gold + 1;
        Debug.Log(gold);
        byte red = 255;
        red++;
        Debug.Log(red);
    }



}
