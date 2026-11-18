using UnityEngine;

namespace FakeMG.CharacterCustomization.Item
{
	[CreateAssetMenu(menuName = "Customization/Bike")]
	public class BikeSO : CustomizationItemSO
	{
		[Header("Bike")]
		[SerializeField]
		private float boostTime;

		[SerializeField]
		private Vector3 leftArmLocalOffset;

		[SerializeField]
		private Vector3 leftLegLocalOffset;

		[SerializeField]
		private Vector3 plateLocalPosition;

		[Header("Upgrade")]
		public int[] cost;

		public int[] additionalBoostTime;

		public float BoostTime => 0f;

		public Vector3 LeftArmLocalOffset => default;

		public Vector3 LeftLegLocalOffset => default;

		public Vector3 PlateLocalPosition => default;
	}
}
