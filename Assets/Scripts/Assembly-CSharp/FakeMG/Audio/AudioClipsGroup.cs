using System;
using UnityEngine;

namespace FakeMG.Audio
{
	[Serializable]
	public class AudioClipsGroup
	{
		public enum SequenceMode
		{
			Random = 0,
			RandomNoImmediateRepeat = 1,
			Sequential = 2
		}

		public SequenceMode sequenceMode;

		public AudioClip[] audioClips;

		private int _nextClipToPlay;

		private int _lastClipPlayed;

		public AudioClip GetNextClip()
		{
			return null;
		}
	}
}
