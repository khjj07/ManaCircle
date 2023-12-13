using System;
using ManaCircle.Scripts.Utility;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace ManaCircle.Scripts.Systems
{
    public class GlobalInputBinder : Singleton<GlobalInputBinder>
    {
        public IObservable<Unit> CreateGetKeyStream(KeyCode key)
        {
           return this.UpdateAsObservable().Where(_ => Input.GetKey(key));
        }
        public IObservable<Unit> CreateGetKeyDownStream(KeyCode key)
        {
            return this.UpdateAsObservable().Where(_ => Input.GetKeyDown(key));
        }
        public IObservable<Unit> CreateGetKeyUpStream(KeyCode key)
        {
            return this.UpdateAsObservable().Where(_ => Input.GetKeyUp(key));
        }

        public IObservable<Unit> CreateGetMouseButtonStream(int btn)
        {
            return this.UpdateAsObservable().Where(_ => Input.GetMouseButton(btn));
        }
        public IObservable<Unit> CreateGetMouseButtonDownStream(int btn)
        {
            return this.UpdateAsObservable().Where(_ => Input.GetMouseButtonDown(btn));
        }

        public IObservable<Unit> CreateGetMouseButtonUpStream(int btn)
        {
            return this.UpdateAsObservable().Where(_ => Input.GetMouseButtonUp(btn));
        }

    }
}
