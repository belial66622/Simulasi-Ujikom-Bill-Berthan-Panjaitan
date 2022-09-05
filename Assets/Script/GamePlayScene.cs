using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using simulasi.gameTimers;
using TMPro;

namespace simulasi.gamescene
{
    public class GamePlayScene : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI timer;

        [SerializeField] GameTimer _gameTimer;
        private void OnEnable()
        {
            _gameTimer.TimerTick += ChangeTimer;
        }

        private void OnDisable()
        {
            _gameTimer.TimerTick -= ChangeTimer;
        }

        void ChangeTimer(int time)
        {
            Convert(time);
        }

        void Convert(int change)
        {
            int a = change;
            string b = "00" + (change % 60).ToString();
            timer.text = "0" + Mathf.FloorToInt(a / 60).ToString() + " : " + b.Substring(b.Length - 2);
        }
    }
}