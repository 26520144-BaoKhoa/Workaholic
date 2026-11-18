using FakeMG.BonusRun.Flying;
using UnityEngine;

namespace FakeMG.BonusRun
{
	public class BonusRunTrigger : MonoBehaviour
	{
		[SerializeField]
		private ActivateFlying activateFlying;

		private bool _activated;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnDisable()
		{
		}
	}
}
