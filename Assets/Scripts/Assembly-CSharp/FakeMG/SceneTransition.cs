using UnityEngine;
using UnityEngine.Events;

namespace FakeMG
{
	public class SceneTransition : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup fadeCanvasGroup;

		public UnityEvent OnFadeOutComplete;

		private void Start()
		{
		}

		public void FadeOut(UnityAction onComplete)
		{
		}

		public void FadeOut()
		{
		}

		public void FadeIn()
		{
		}
	}
}
