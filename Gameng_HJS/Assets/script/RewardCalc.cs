using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234 ;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;

    public float expRate = 1.5f;


    [ContextMenu("전치")]
    void Time()
    {
        int H = (playSeconds/60/60);
        int M = (playSeconds/60%60);
        int S = (playSeconds%60);
        Debug.Log(H + "시간" + M + "분" + S + "초"); 
    }
    
    [ContextMenu("사딸라")]
    void Gold()
    {
        Debug.Log("1인당" + (gold/members) + "골드, " + "리더 보너스" + (gold%members) + "골드");
        
    }

    [ContextMenu("뜯은 삥")]
    void Exp()
    {
        int DExp = (kills*expPerKill);
        float FExp = (DExp * expRate);


        Debug.Log("경험치 " + (int)FExp + " (기본 " + DExp + ")");
    }

    [ContextMenu("뜯기력")]
    void NextLv()
    {
        int DExp = (kills * expPerKill);
        float FExp = (DExp * expRate);
        float Lv = (FExp / 100 + 1);

        Debug.Log("Lv" + (int)Lv + " 다음 레벨까지 " + (100 - (int)FExp % 100));
    }

    [ContextMenu("평균 호두 적중")]
    void DMG()
    {
        Debug.Log("평균 데미지 " + (float)totalDamage / hits);
    }
}
