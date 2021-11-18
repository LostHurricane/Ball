using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace GeekProject
{
    public class MainCanvas : MonoBehaviour
    {
        [SerializeField]
        private GameObject _WinPanel;

        public Text BonusCounter;
        
        public void Win()
        {
            _WinPanel.SetActive(true);
        }
    }
}