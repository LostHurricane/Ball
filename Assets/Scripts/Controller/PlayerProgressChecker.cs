using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    public sealed class PlayerProgressChecker : ICleanup
    {
        public delegate void _win();
        public event _win WinGame;

        public int PointsToWin { get; private set; }

        private int collectedBonuses = 0;

        private Object[] _bonuses;

        private MainCanvas _mainCanvas;
        public PlayerProgressChecker(int pointsToWin)
        {
            _mainCanvas = Object.FindObjectOfType<MainCanvas>();
            _mainCanvas.BonusCounter.text = "Bonuses: " + collectedBonuses + "/" + pointsToWin;

            PointsToWin = pointsToWin;

            _bonuses = Object.FindObjectsOfType<BonusCollectable>();
            foreach (BonusCollectable bc in _bonuses)
            {
                bc.Effect += BonusChanged;
            }

            WinGame +=_mainCanvas.Win;
        }

        public void BonusChanged(int bonus)
        {
            collectedBonuses += bonus;
            _mainCanvas.BonusCounter.text = "Bonuses: " + collectedBonuses.ToString() + "/" + PointsToWin.ToString() ;
            if (collectedBonuses >= PointsToWin)
            {
                EndGame();
                Debug.Log("Win");
            }
        }

        public void Cleanup()
        {
            foreach (BonusCollectable bc in _bonuses)
            {
                bc.Effect -= BonusChanged;
            }
            WinGame -= _mainCanvas.Win;


        }

        private void EndGame()
        {
            WinGame?.Invoke();
        }

    }
}