using System;
using System.Collections.Generic;
using UnityEngine;

namespace FakeMG.Curve
{
	[Serializable]
	public class QuadraticCurve
	{
		[SerializeField]
		public List<Vector2> points;

		[SerializeField]
		public List<Vector2> pointsOnCurve;

		public QuadraticCurve(Vector2 center)
		{
		}

		public QuadraticCurve(Vector2 p0, Vector2 p1, Vector2 p2)
		{
		}

		public List<Vector2> GenerateEvenlySpacedPoints(float distanceBetweenPoints = 0.5f, int resolution = 1)
		{
			return null;
		}

		private Vector2 EvaluateQuadraticCurve(Vector2 a, Vector2 b, Vector2 c, float t)
		{
			return default;
		}
	}
}
