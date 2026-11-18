using UnityEngine;

namespace FakeMG.Shader
{
	[ExecuteInEditMode]
	public class CurvedWorld : MonoBehaviour
	{
		public Vector3 curvature;

		public float distance;

		[Space]
		public float curvatureScaleUnit;

		private int _curvatureID;

		private int _distanceID;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
