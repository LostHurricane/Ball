using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgressChecker //: MonoBehaviour
{
    public int PointsToWin { get; private set; }

    private int collectedBonuses = 0;

    public PlayerProgressChecker (int pointsToWin)
    {
            PointsToWin = pointsToWin;
    }

    public void BonusChanged(int bonus)
    {
        collectedBonuses += bonus;
        Debug.Log("Bonuses " + collectedBonuses);
        if (collectedBonuses >= PointsToWin)
        {
            Debug.Log("Win");
        }
    }


}
