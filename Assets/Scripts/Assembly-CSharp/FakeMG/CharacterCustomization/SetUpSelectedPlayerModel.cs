using System;
using FakeMG.CharacterCustomization.Item;
using FakeMG.PowerUps.Shield;
using FakeMG.Server.SaveLoad;
using TMPro;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace FakeMG.CharacterCustomization
{
	public class SetUpSelectedPlayerModel : MonoBehaviour
	{
		[SerializeField]
		[Header("Player Model")]
		private GameObject parentOfDriverModel;

		[SerializeField]
		private GameObject currentSpawnedDriverModel;

		[SerializeField]
		private Animator animationRiggingAnimator;

		[SerializeField]
		private TakeDamage takeDamage;

		private AsyncOperationHandle<CustomizationItemSO> _driverHandle;

		private const string DRIVER_KEY = "DriverId";

		private const string DRIVER_DEFAULT = "ninja_lead";

		[SerializeField]
		[Header("Bike Model")]
		private GameObject parentOfBikeModel;

		[SerializeField]
		private GameObject currentSpawnedBikeModel;

		[SerializeField]
		private UnityEvent<float> onBikeModelLoaded;

		private AsyncOperationHandle<BikeSO> _bikeHandle;

		private const string BIKE_KEY = "BikeId";

		private const string BIKE_DEFAULT = "lead_normal";

		[Header("Nitro Particle System")]
		[SerializeField]
		private GameObject parentOfNitroParticleSystem;

		[SerializeField]
		private GameObject currentSpawnedNitroParticleSystem;

		[SerializeField]
		private bool nitroStartOnAwake;

		[SerializeField]
		private UnityEvent<ParticleSystem> onNitroModelLoaded;

		private AsyncOperationHandle<CustomizationItemSO> _nitroHandle;

		private const string NITRO_KEY = "NitroId";

		private const string NITRO_DEFAULT = "nitro_blue";

		[SerializeField]
		[Header("Plate Number")]
		private TextMeshPro plateNumberLine1;

		[SerializeField]
		private TextMeshPro plateNumberLine2;

		[SerializeField]
		[Header("Rig")]
		private MultiRotationConstraint multiRotationConstraint;

		[SerializeField]
		private MultiPositionConstraint leftArmPositionConstraint;

		[SerializeField]
		private MultiPositionConstraint rightArmPositionConstraint;

		[SerializeField]
		private MultiPositionConstraint leftLegPositionConstraint;

		[SerializeField]
		private MultiPositionConstraint rightLegPositionConstraint;

		[SerializeField]
		private RigBuilder rigBuilder;

		[SerializeField]
		private Rig rig;

		[SerializeField]
		[Header("Other")]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private Transform plate;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void LoadNitroModel()
		{
		}

		private void LoadDriverModel(Action onDriverModelLoaded)
		{
		}

		private void LoadBikeModel()
		{
		}

		private string GetModelID(string key, string defaultValue)
		{
			return null;
		}

		public void ReplaceNitroModel(CustomizationItemSO nitroAsset)
		{
		}

		public void ReplaceDriverModel(CustomizationItemSO driverAsset)
		{
		}

		public void ReplaceBikeModel(BikeSO bikeAsset)
		{
		}

		private void SetUpConstraintsLocalPosition(BikeSO bikeAsset)
		{
		}

		private void SetUpRig(GameObject newModel)
		{
		}
	}
}
