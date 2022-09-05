using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace simulasi.gameTimers
{
    public class GameTimer : MonoBehaviour
    {
        public event Action<int> TimerTick;
        bool _tick;
        [SerializeField] int time;
        // Start is called before the first frame update
        void Start()
        {

                StartCoroutine(timer());

        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator timer()
        {
            while (time > 0)
            {
                TimerTick?.Invoke(time);
                yield return new WaitForSeconds(1);
                time -= 1;
            }



        }
    }
}