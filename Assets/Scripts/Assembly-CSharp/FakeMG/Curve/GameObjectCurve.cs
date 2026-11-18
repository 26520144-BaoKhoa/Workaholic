using System.Collections.Generic;
using UnityEngine;

namespace FakeMG.Curve
{
	public class GameObjectCurve : MonoBehaviour
	{
		public QuadraticCurve curve;

		[Min(0.1f)]
		public float distanceBetweenPoints;

		[SerializeField]
		public Transform[] path;

		[SerializeField]
		private List<Vector2> relativePos;

		public void SetupRelativePos()
		{
		}

		public void UpdatePointsOnCurvePos()
		{
		}
	}
}
