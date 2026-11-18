using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace FakeMG.Movement
{
	public class KartController : MonoBehaviour
	{
		[Header("Collision")]
		[SerializeField]
		private float sideCollisionCheckDistance;

		[SerializeField]
		private float groundCheckDistance;

		[SerializeField]
		[Header("Parameters")]
		public float maxSpeed;

		[SerializeField]
		private float gravity;

		[SerializeField]
		[Header("Steering")]
		private float maxSteerAmount;

		[SerializeField]
		private float zSteerAmount;

		[SerializeField]
		private float extraSteeringMultiplier;

		[SerializeField]
		private float steerSpeed;

		[SerializeField]
		private float steerSensitive;

		private bool _isEnableSteer;

		[SerializeField]
		[Header("Drift")]
		private float driftPowerThreshold;

		[SerializeField]
		private float driftPowerIncreaseSpeed;

		[SerializeField]
		private UnityEvent onDrift;

		[SerializeField]
		private UnityEvent<double, double> whileDrift;

		[SerializeField]
		private UnityEvent onDriftComplete;

		[SerializeField]
		[Header("Boost")]
		private float boostSpeedMultiplier;

		[SerializeField]
		private LayerMask obstacleLayer;

		[SerializeField]
		private UnityEvent onBoost;

		[SerializeField]
		private UnityEvent onBoostComplete;

		private float _boostTime;

		[SerializeField]
		[Header("Particles")]
		private CinemachineVirtualCamera camera;

		[SerializeField]
		private ParticleSystem wheelParticles;

		private bool _isDrifting;

		private int _driftDirection;

		private float _currentDriftPower;

		private bool _isBoosting;

		private float _yRotateAmount;

		private float _zRotateAmount;

		private bool _isGrounded;

		private PlayerInput _playerInput;

		private Vector2 _movementInput;

		private InputAction _moveAction;

		private InputAction _driftAction;

		private InputAction _driftDirectionAction;

		private InputAction _boostAction;

		private bool _firstTouchAfterUnfocused;

		private Transform _transform;

		private Rigidbody _rigidbody;

		private bool _collideLeft;

		private bool _collideRight;

		private readonly List<RaycastResult> _rayCastResultsList;

		public float CurrentSpeed { get; private set; }

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnCollisionStay(Collision other)
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void OnDriftPerformed(InputAction.CallbackContext context)
		{
		}

		private void OnDriftCanceled(InputAction.CallbackContext context)
		{
		}

		private void StopDrifting()
		{
		}

		private void OnBoostPerformed(InputAction.CallbackContext context)
		{
		}

		private void CalculateNormalSpeed()
		{
		}

		private void CalculateNormalRotation()
		{
		}

		private void CalculateExtraRotation()
		{
		}

		private void CalculateDriftPower(float changeSpeed)
		{
		}

		private void CheckIfStillCollidingFromSide()
		{
		}

		private void StopRotatingWhenCollideFromSide()
		{
		}

		private void SpinKartToRotateAmount()
		{
		}

		private void ParallelizeKart()
		{
		}

		public void SetBoostTime(float time)
		{
		}

		private void Boost()
		{
		}

		public void BoostUtility(float time)
		{
		}

		private void DisableEnemy()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
