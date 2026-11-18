using UnityEngine;
using UnityEngine.InputSystem;

namespace FakeMG
{
	public class RotateModel : MonoBehaviour
	{
		[SerializeField]
		private GameObject model;

		[SerializeField]
		private PlayerInput playerInput;

		private InputAction _rotateAction;

		private InputAction _driftAction;

		private InputAction _driftDirectionAction;

		private Vector2 _modelScreenPos;

		private Vector2 _inputPos;

		private bool _isRotating;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDriftPerform(InputAction.CallbackContext context)
		{
		}

		private void OnDriftCancel(InputAction.CallbackContext context)
		{
		}
	}
}
