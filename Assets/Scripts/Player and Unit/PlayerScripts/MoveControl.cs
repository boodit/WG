using UnityEngine;
using UnityEngine.InputSystem;

public class MoveControl : MonoBehaviour, IConrolable
{
    [Header("Move")]
    [SerializeField] private float _runSpeed = 3;
    [SerializeField] private float _speed = 1;
    [Header("Gravity")]
    [SerializeField] private float _gravity = 9.8f;
    [SerializeField] private float _groundGravity = 0.5f;
    [Header("Jump")]
    [SerializeField] private float _maxJumpHeight = 2.5f;
    [SerializeField] private float _maxJumpTime = 0.65f;
    
    
    private PlayerInput _inputPlayer;
    private CharacterController _characterController;
    private Vector2 _currentMovementInput;
    private Vector3 _currentMovement;
    private Vector3 _currentRunMovement;
    private Vector3 _applideMovement;
    //private float _rotationFactorPerFrame = 10f;
    private Camera _mCam;
    private float _initialJumpVelocity;
    
    
    private bool isMovementPressed;
    private bool isRunPressed;
    private bool isJumpPressed;
    private bool isJumping;
    

    public bool IsMovePress => isMovementPressed;
    public bool IsRunPress => isRunPressed;


    private void Awake()
    {
        _mCam = Camera.main;
        _gravity = -_gravity;
        _groundGravity = -_groundGravity;
        _inputPlayer = new PlayerInput();
        _characterController = GetComponent<CharacterController>();
        _inputPlayer.Player.Move.started += OnMovementInput;
        _inputPlayer.Player.Move.canceled += OnMovementInput;
        _inputPlayer.Player.Move.performed += OnMovementInput;
        _inputPlayer.Player.Run.started += OnRun;
        _inputPlayer.Player.Run.canceled += OnRun;
        _inputPlayer.Player.Jump.started += OnJump;
        _inputPlayer.Player.Jump.canceled += OnJump;
        SetupJumpVariables();
    }
    
    private void OnEnable()
    {
        _inputPlayer.Player.Enable();
    }
    private void OnDisable()
    {
        _inputPlayer.Player.Move.started -= OnMovementInput;
        _inputPlayer.Player.Move.canceled -= OnMovementInput;
        _inputPlayer.Player.Move.performed -= OnMovementInput;
        _inputPlayer.Player.Run.started -= OnRun;
        _inputPlayer.Player.Run.canceled -= OnRun;
        _inputPlayer.Player.Jump.started -= OnJump;
        _inputPlayer.Player.Jump.canceled -= OnJump;
        _inputPlayer.Player.Disable();
    }

    private void Update()
    {
        MouseRotation();
        Move();
        HandleGravity();
        HandleJump();
    }

    public void Move() 
    {
        if (!isRunPressed)
        {
            _applideMovement.x = _currentMovement.x;
            _applideMovement.z = _currentMovement.z;
        }
        else
        {
            _applideMovement.x = _currentRunMovement.x;
            _applideMovement.z = _currentRunMovement.z;
        }
        _characterController.Move(_applideMovement *Time.deltaTime); 
    }
    
    // Идет в сторону курсора
    
    // public void Move() 
    // {
    //     Vector3 moveDirection = transform.forward * _currentMovementInput.y + transform.right * _currentMovementInput.x;
    //     Vector3 movement = moveDirection * (isRunPressed ? _runSpeed : _speed);
    //
    //     if (!_characterController.isGrounded)
    //     {
    //         movement.y = _gravity;
    //     }
    //
    //     _characterController.Move(movement * Time.deltaTime);
    // }

    private void OnMovementInput(InputAction.CallbackContext context)
    {
        _currentMovementInput = context.ReadValue<Vector2>();
        _currentMovement.x = _currentMovementInput.x * _speed;
        _currentMovement.z = _currentMovementInput.y * _speed;
        _currentRunMovement.x = _currentMovementInput.x * _runSpeed;
        _currentRunMovement.z = _currentMovementInput.y * _runSpeed;
        isMovementPressed = _currentMovementInput.x != 0 || _currentMovementInput.y != 0; 
    }

    private void OnRun(InputAction.CallbackContext context)
    {
        isRunPressed = context.ReadValueAsButton();
    }
    // private void HandleRotation()
    // {
    //     Vector3 positionToLookAt;
    //     positionToLookAt.x = _currentMovement.x;
    //     positionToLookAt.y = 0f;
    //     positionToLookAt.z = _currentMovement.z;
    //     Quaternion currentRotation = transform.rotation;
    //
    //     if (isMovementPressed)
    //     {
    //         Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
    //         transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, _rotationFactorPerFrame * Time.deltaTime);
    //     }
    //     
    // }

    private void MouseRotation()
    {
        Ray mouseRay = _mCam.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(mouseRay, out RaycastHit mousePos);
        Vector3 positionToLookAt = mousePos.point - transform.position;
        positionToLookAt.y = 0f;
        transform.forward = positionToLookAt.normalized;


    }

    private void OnJump(InputAction.CallbackContext context)
    {
        isJumpPressed = context.ReadValueAsButton();
        
    }

    private void SetupJumpVariables()
    {
        
        float timeToApex = _maxJumpTime / 2;
        _gravity = (-2 * _maxJumpHeight) / Mathf.Pow(timeToApex, 2);
        _initialJumpVelocity = (2 * _maxJumpHeight) / timeToApex;
    }

    private void HandleJump()
    {
        if (!isJumping && _characterController.isGrounded && isJumpPressed)
        {
            isJumping = true;
            _currentMovement.y = _initialJumpVelocity;
            _applideMovement.y = _initialJumpVelocity; 
        }
        else if (!isJumpPressed && _characterController.isGrounded && isJumping)
        {
            isJumping = false;
        }
    }

    private void HandleGravity()
    {
        bool isFalling = _currentMovement.y <= 0.0f || !isJumpPressed;
        float fallMultiplier = 2.0f;
        
        if (_characterController.isGrounded)
        {
            _currentMovement.y = _groundGravity ;
            _applideMovement.y = _groundGravity ;
        }
        else if (isFalling)
        {
            float previousYVelocity = _currentMovement.y;
            _currentMovement.y += (_gravity * fallMultiplier * Time.deltaTime);
            _applideMovement.y = Mathf.Max((previousYVelocity + _currentMovement.y) * .5f , -20f) ;
        }
        else
        {
            float previousYVelocity = _currentMovement.y;
            _currentMovement.y += (_gravity * Time.deltaTime);
            _applideMovement.y = (previousYVelocity + _currentMovement.y) * .5f;
        }
    }
}
