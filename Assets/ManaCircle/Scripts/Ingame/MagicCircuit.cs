using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.ManaCircle.Scripts.Ingame
{
    [Serializable]
    public class MagicCircuit
    {
        [Header("�ڽ�Ʈ �뷮"), SerializeField]
        private int _costCapacity;
        [Header("���� �ڽ�Ʈ"),SerializeField]
        private int _currentCost;
        [Header("����Ŭ �ð�(��)"), SerializeField]
        private float _cycleTime;
        private float _progress;
        private List<Magic> _magics;

        public void Run()
        {

        }

    }
}
