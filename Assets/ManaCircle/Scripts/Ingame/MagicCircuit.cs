using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.ManaCircle.Scripts.Ingame
{
    [Serializable]
    public class MagicCircuit
    {
        [Header("코스트 용량"), SerializeField]
        private int _costCapacity;
        [Header("현재 코스트"),SerializeField]
        private int _currentCost;
        [Header("사이클 시간(초)"), SerializeField]
        private float _cycleTime;
        private float _progress;
        private List<Magic> _magics;

        public void Run()
        {

        }

    }
}
