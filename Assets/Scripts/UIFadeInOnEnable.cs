using System.Collections;
using UnityEngine;

namespace dev.xrlab.byos.ui
{
    [RequireComponent(typeof(CanvasGroup))]
    public class UIFadeInOnEnable : MonoBehaviour
    {
        [Header("Timing")]
        [SerializeField] private float delay = 0f;
        [SerializeField] private float duration = 0.5f;

        private CanvasGroup canvasGroup;

        private void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        private void OnEnable()
        {
            StopAllCoroutines();
            StartCoroutine(FadeRoutine());
        }

        private IEnumerator FadeRoutine()
        {
            canvasGroup.alpha = 0f;

            if (delay > 0f)
                yield return new WaitForSeconds(delay);

            float time = 0f;

            while (time < duration)
            {
                time += Time.deltaTime;
                canvasGroup.alpha = Mathf.Clamp01(time / duration);
                yield return null;
            }

            canvasGroup.alpha = 1f;
        }
    }
}