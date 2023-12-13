using System;
using System.Collections;
using System.Threading.Tasks;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ManaCircle.Scripts.Systems
{
    public class SplashManager : MonoBehaviour
    {
        [SerializeField]
        private float minimumDelaySecond;
        [SerializeField]
        private string targetScene;
        // Start is called before the first frame update
        void Start()
        {
            Observable.FromCoroutine<AsyncOperation>(LoadSceneAysnc)
                .Where(x => x.progress >= 0.9f)
                .Subscribe(x =>
                {
                    OnSceneLoaded(x);
                });

        }

        private void OnSceneLoaded(AsyncOperation asyncOperation)
        {
#if UNITY_EDITOR
            Debug.Log("Almost Loaded");
#endif
            GlobalInputBinder.Instance.CreateGetKeyDownStream(KeyCode.Space)
                .Subscribe(_=>asyncOperation.allowSceneActivation = true)
                .AddTo(gameObject);
        }

        private IEnumerator LoadSceneAysnc(IObserver<AsyncOperation> observer)
        {
            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(targetScene);
            asyncOperation.allowSceneActivation = false;
            observer.OnNext(asyncOperation);
            yield return new WaitForSeconds(minimumDelaySecond);
            while (asyncOperation.progress < 0.9f)
            {
                observer.OnNext(asyncOperation);
                yield return asyncOperation;
            }
            observer.OnNext(asyncOperation);
            yield return null;
        }
    }
}
