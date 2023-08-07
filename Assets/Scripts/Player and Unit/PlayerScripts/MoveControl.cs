using UnityEngine;
using UnityEngine.InputSystem;

public class MoveControl : MonoBehaviour, IConrolable
{
    [SerializeField] private float _runSpeed = 3;
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _gravity = 9.8f;
    

    
    private PlayerInput _inputPlayer;
    private CharacterController _characterController;
    private Vector2 _currentMovementInput;
    private Vector3 _currentMovement;
    private Vector3 _currentRunMovement;
    private float _rotationFactorPerFrame = 10f;
    private Camera _mCam;
    
    private bool isMovementPressed;
    private bool isRunPressed;
    

    public bool IsMovePress => isMovementPressed;
    public bool IsRunPress => isRunPressed;


    private void Awake()
    {
        _mCam = Camera.main;
        _gravity = -_gravity;
        _inputPlayer = new PlayerInput();
        _characterController = GetComponent<CharacterController>();
        _inputPlayer.Player.Move.started += OnMovemendInput;
        _inputPlayer.Player.Move.canceled += OnMovemendInput;
        _inputPlayer.Player.Move.performed += OnMovemendInput;
        _inputPlayer.Player.Run.started += OnRun;
        _inputPlayer.Player.Run.canceled += OnRun;
    }
    
    private void OnEnable()
    {
        _inputPlayer.Player.Enable();
    }
    private void OnDisable()
    {
        _inputPlayer.Player.Move.started -= OnMovemendInput;
        _inputPlayer.Player.Move.canceled -= OnMovemendInput;
        _inputPlayer.Player.Move.performed -= OnMovemendInput;
        _inputPlayer.Player.Run.started -= OnRun;
        _inputPlayer.Player.Run.canceled -= OnRun;
        _inputPlayer.Player.Disable();
    }

    private void Update()
    {
        //HandleRotation();
        MouseRotation();
        Move();
        HandleGravity();
    }

    public void Move() 
    {
        if (isRunPressed)
        {
            _characterController.Move(_currentRunMovement * Time.deltaTime);
        }
        else
        {
            _characterController.Move(_currentMovement*Time.deltaTime);  
        }
    }

    private void OnMovemendInput(InputAction.CallbackContext context)
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
    private void HandleRotation()
    {
        Vector3 positionToLookAt;
        positionToLookAt.x = _currentMovement.x;
        positionToLookAt.y = 0f;
        positionToLookAt.z = _currentMovement.z;
        Quaternion currentRotation = transform.rotation;

        if (isMovementPressed)
        {
            Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
            transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, _rotationFactorPerFrame * Time.deltaTime);
        }
        
    }

    private void MouseRotation()
    {
        Ray mouseRay = _mCam.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(mouseRay, out RaycastHit mousePos);
        Vector3 positionToLookAt = mousePos.point - transform.position;
        positionToLookAt.y = 0f;
        transform.forward = positionToLookAt;


    }

    private void HandleGravity()
    {
        if (!_characterController.isGrounded)
        {
            _currentMovement.y = _gravity ;
            _currentRunMovement.y = _gravity ;
        }
        else
        {
            _currentMovement.y = -0.5f;
            _currentRunMovement.y = -0.5f; 
        }
    }
}
