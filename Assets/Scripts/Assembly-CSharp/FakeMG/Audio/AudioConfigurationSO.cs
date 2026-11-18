using UnityEngine;
using UnityEngine.Audio;

namespace FakeMG.Audio
{
	[CreateAssetMenu(menuName = "Audio/AudioConfigurationSO")]
	public class AudioConfigurationSO : ScriptableObject
	{
		private enum PriorityLevel
		{
			Highest = 0,
			High = 64,
			Standard = 128,
			Low = 194,
			VeryLow = 256
		}

		public AudioMixerGroup outputAudioMixerGroup;

		[SerializeField]
		private PriorityLevel priorityLevel;

		[Header("Sound properties")]
		public bool mute;

		[Range(0f, 1f)]
		public float volume;

		[Range(-3f, 3f)]
		public float pitch;

		[Range(-1f, 1f)]
		public float panStereo;

		[Range(0f, 1.1f)]
		public float reverbZoneMix;

		[Range(0f, 1f)]
		[Header("Spatialisation")]
		public float spatialBlend;

		public AudioRolloffMode rollOffMode;

		[Range(0.01f, 5f)]
		public float minDistance;

		[Range(5f, 100f)]
		public float maxDistance;

		[Range(0f, 360f)]
		public int spread;

		[Range(0f, 5f)]
		public float dopplerLevel;

		[Header("Ignores")]
		public bool bypassEffects;

		public bool bypassListenerEffects;

		public bool bypassReverbZones;

		public bool ignoreListenerVolume;

		public bool ignoreListenerPause;

		public int Priority
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void ApplyTo(AudioSource audioSource)
		{
		}
	}
}
