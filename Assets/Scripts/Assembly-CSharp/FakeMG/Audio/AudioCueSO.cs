using UnityEngine;

namespace FakeMG.Audio
{
	[CreateAssetMenu(menuName = "Audio/AudioCueSO")]
	public class AudioCueSO : ScriptableObject
	{
		public bool looping;

		public bool fadeIn;

		public float fadeInDuration;

		public bool fadeOut;

		public float fadeOutDuration;

		[SerializeField]
		private AudioClipsGroup[] _audioClipGroups;

		public AudioClip[] GetClips()
		{
			return null;
		}
	}
}
