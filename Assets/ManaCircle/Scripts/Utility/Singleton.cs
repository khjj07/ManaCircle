using UnityEngine;

namespace ManaCircle.Scripts.Utility
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour 
    {
        private T _instance;

        public T instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Object.FindObjectOfType<T>();
                }
                return _instance;
            }
        }
    }
}
