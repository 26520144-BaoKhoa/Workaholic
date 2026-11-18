using System.Collections.Generic;
using UnityEngine;

namespace FakeMG
{
	public class RandomMaterial : MonoBehaviour
	{
		[SerializeField]
		private List<Material> materials;

		private Renderer _renderer;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}
	}
}
