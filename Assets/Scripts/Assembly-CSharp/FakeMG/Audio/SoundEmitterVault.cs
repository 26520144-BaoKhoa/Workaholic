using System.Collections.Generic;

namespace FakeMG.Audio
{
	public class SoundEmitterVault
	{
		private int _nextUniqueKey;

		private readonly List<AudioCueKey> _emittersKey;

		private readonly List<List<SoundEmitter>> _emittersListOfList;

		private AudioCueKey GetKey(AudioCueSO cue)
		{
			return default;
		}

		public AudioCueKey Add(AudioCueSO cue, List<SoundEmitter> soundEmitterList)
		{
			return default;
		}

		public bool Get(AudioCueKey key, out List<SoundEmitter> soundEmitterList)
		{
			soundEmitterList = null;
			return false;
		}

		public bool Remove(AudioCueKey key)
		{
			return false;
		}

		private bool RemoveAt(int index)
		{
			return false;
		}
	}
}
