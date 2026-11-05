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
        
        
        Debug.Log(DExp*expRate + (DExp));
    }

}
