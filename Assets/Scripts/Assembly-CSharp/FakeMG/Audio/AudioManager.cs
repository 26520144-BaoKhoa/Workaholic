using FakeMG.EventChannels;
using UnityEngine;
using UnityEngine.Audio;

namespace FakeMG.Audio
{
	public class AudioManager : MonoBehaviour
	{
		[SerializeField]
		[Header("Prefab")]
		private GameObject soundEmitterPrefab;

		[SerializeField]
		private SoundEmitter musicSoundEmitter;

		[Tooltip("The SoundManager listens to this event, fired by objects in any scene, to play SFXs")]
		[Header("Listening on channels")]
		[SerializeField]
		public AudioCueEventChannelSO sfxEventChannel;

		[SerializeField]
		public AudioCueEventChannelSO musicEventChannel;

		[Tooltip("The SoundManager listens to this event, fired by objects in any scene, to change SFXs volume")]
		[SerializeField]
		private FloatEventChannel sfxVolumeEventChannel;

		[Tooltip("The SoundManager listens to this event, fired by objects in any scene, to change Music volume")]
		[SerializeField]
		private FloatEventChannel musicVolumeEventChannel;

		[Tooltip("The SoundManager listens to this event, fired by objects in any scene, to change Master volume")]
		[SerializeField]
		private FloatEventChannel masterVolumeEventChannel;

		[Header("Audio control")]
		[SerializeField]
		private AudioMixer audioMixer;

		private PoolInitializer _poolInitializer;

		private SoundEmitterVault _soundEmitterVault;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void ChangeMasterVolume(float newVolume)
		{
		}

		private void ChangeMusicVolume(float newVolume)
		{
		}

		private void ChangeSfxVolume(float newVolume)
		{
		}

		private void SetGroupVolume(string parameterName, float normalizedVolume)
		{
		}

		private float NormalizedToMixerValue(float normalizedValue)
		{
			return 0f;
		}

		private AudioCueKey PlayMusicTrack(AudioCueSO audioCue, AudioConfigurationSO audioConfiguration, Vector3 positionInSpace, Transform parent = null)
		{
			return default;
		}

		private bool StopMusic(AudioCueKey key, AudioCueSO audioCue)
		{
			return false;
		}

		private void StopMusicEmitter(SoundEmitter soundEmitter)
		{
		}

		private AudioCueKey PlayAudioCue(AudioCueSO audioCue, AudioConfigurationSO settings, Vector3 position = default(Vector3), Transform parent = null)
		{
			return default;
		}

		private bool StopAudioCue(AudioCueKey audioCueKey, AudioCueSO audioCue)
		{
			return false;
		}

		private bool FinishAudioCue(AudioCueKey audioCueKey)
		{
			return false;
		}

		private void StopAndCleanEmitter(SoundEmitter soundEmitter)
		{
		}

		public void CleanPool()
		{
		}
	}
}
