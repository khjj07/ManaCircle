using Assets.ManaCircle.Scripts.Systems.Global;
using UniRx;
using UnityEngine;

namespace Assets.ManaCircle.Scripts.Ingame
{
    public class Player : MonoBehaviour
    {
        #region 이동관련
        [SerializeField]
        private float _speed = 3.0f;
        #endregion
        


        void Start()
        {
            GlobalInputBinder.Instance.CreateGetAxisStream("Horizontal").Subscribe(MoveHorizontal).AddTo(gameObject);
            GlobalInputBinder.Instance.CreateGetAxisStream("Vertical").Subscribe(MoveVertical).AddTo(gameObject);
        }

        void MoveHorizontal(float direction)
        {
            transform.Translate(Vector3.right* direction * _speed * Time.deltaTime);
        }

        void MoveVertical(float direction)
        {
            transform.Translate(Vector3.forward * direction * _speed * Time.deltaTime);
        }
    }
}
