using UnityEngine.InputSystem;
using UnityEngine;

public class AnimationP : MonoBehaviour
{
    private Animator _animator;
    private int _isVelocityXHash;
    private int _isVelocityZHash;
    [SerializeField]private Transform _target;
    private Vector3 _previousPosition;
    private PlayerInput _inputPlayer;
    private bool isRunPressed = false;
    private float _velocityX;
    private float _velocityZ;
    private int _mutliply = 2;

    private void Awake()
    {
        _inputPlayer = new PlayerInput();
        _inputPlayer.Player.Run.started += OnRun;
        _inputPlayer.Player.Run.canceled += OnRun;
        _animator = GetComponent<Animator>();
        _isVelocityZHash = Animator.StringToHash("VelocityX");
        _isVelocityXHash = Animator.StringToHash("VelocityZ");  
    }
    private void OnEnable()
    {
        _inputPlayer.Player.Enable();
    }
    
    private void OnDisable()
    {
        _inputPlayer.Player.Run.started -= OnRun;
        _inputPlayer.Player.Run.canceled -= OnRun;
        _inputPlayer.Player.Disable();
    }

    private void Start()
    {
        _previousPosition = _target.position;
    }

    private void Update()
    {
        MoveVelocityXZ();
    }

    private void MoveVelocityXZ()
    {
        Vector3 displacement = _target.position - _previousPosition;

        Vector3 localDisplacement = _target.InverseTransformDirection(displacement);
        
        localDisplacement.Normalize();

        float forwardDot = Vector3.Dot(localDisplacement, Vector3.forward);
        float rightDot = Vector3.Dot(localDisplacement, Vector3.right);

        #region WalkForward
        
        if (forwardDot > 0.5f && !isRunPressed &&_velocityX < 0.5f)
        {
            _velocityX += Time.deltaTime * _mutliply;
        }
        else if(forwardDot > 0.5f && isRunPressed &&_velocityX < 1f)
        {
            _velocityX += Time.deltaTime * _mutliply;
        }
        else if(forwardDot > 0.5f && _velocityX > 0.5f && !isRunPressed)
        {
            _velocityX -= Time.deltaTime * _mutliply;
        }
        else if (forwardDot < 0.3f && _velocityX > 0f)
        {
            _velocityX -= Time.deltaTime * _mutliply;
            
        }
        
        #endregion

        #region WalkBack
        
        if (forwardDot < -0.5f && !isRunPressed && _velocityX > -0.5f)
        {
            _velocityX -= Time.deltaTime * _mutliply;
        }
        else if(forwardDot < -0.5f && isRunPressed && _velocityX > -1f)
        {
            Debug.Log(forwardDot);
            _velocityX -= Time.deltaTime * _mutliply;
        }
        else if(forwardDot < -0.5f && !isRunPressed && _velocityX < -0.5f)
        {
            _velocityX += Time.deltaTime * _mutliply;
        }
        else if(forwardDot > -0.3f && _velocityX < 0f)
        {
            _velocityX += Time.deltaTime * _mutliply;
        }

        #endregion

        #region RightWalk

        if (rightDot > 0.5f && !isRunPressed &&_velocityZ < 0.5f)
        {
            _velocityZ += Time.deltaTime * _mutliply;
        }
        else if(rightDot > 0.5f && isRunPressed &&_velocityZ < 1f)
        {
            _velocityZ += Time.deltaTime * _mutliply;
        }
        else if(rightDot > 0.5f && _velocityZ > 0.5f && !isRunPressed)
        {
            _velocityZ -= Time.deltaTime * _mutliply;
        }
        else if (rightDot < 0.3f && _velocityZ > 0f)
        {
            _velocityZ -= Time.deltaTime * _mutliply;
            
        }

        #endregion

        #region RightWalk

        if (rightDot < -0.5f && !isRunPressed && _velocityZ > -0.5f)
        {
            _velocityZ -= Time.deltaTime * _mutliply;
        }
        else if(rightDot < -0.5f && isRunPressed && _velocityZ > -1f)
        {
            Debug.Log(forwardDot);
            _velocityZ -= Time.deltaTime * _mutliply;
        }
        else if(rightDot < -0.5f && !isRunPressed && _velocityZ < -0.5f)
        {
            _velocityZ += Time.deltaTime * _mutliply;
        }
        else if(rightDot > -0.3f && _velocityZ < 0f)
        {
            _velocityZ += Time.deltaTime * _mutliply;
        }

        #endregion
        
        _previousPosition = _target.position;
        _animator.SetFloat(_isVelocityXHash,_velocityX);
        _animator.SetFloat(_isVelocityZHash,_velocityZ);
    }

    private void OnRun(InputAction.CallbackContext context)
    {
        isRunPressed = context.ReadValueAsButton();
    }
}
