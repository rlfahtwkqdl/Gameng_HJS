using UnityEngine;
using System.Collections.Generic;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;
    



    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        int total = 0;
        int critical = 0;
        List<int> criticals = new List<int>();


        foreach (int damage in damages)
        {
            total += damage;
            

            if (damage >= criticalLine) 
               {
                critical++;
               
               criticals.Add(damage);
               }
        }
        
        Debug.Log("총 데미지 " + total);

        Debug.Log("치명타 " + critical + "회");

        for (int i = 0; i < critical; i++)
        {
             Debug.Log("치명타 " + criticals[i]);
        }

       


    }
}
