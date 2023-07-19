using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationUnit : MonoBehaviour
{
    private MoveControl _moveControl;
    private Animator _animator;
    private int _isWalingHash;
    private int _isRunningHash;

    private void Awake()
    {
        _moveControl = GetComponent<MoveControl>();
        _animator = GetComponent<Animator>();
        _isWalingHash = Animator.StringToHash("isWalk");
        _isRunningHash = Animator.StringToHash("isRun");  
    }

    private void Update()
    {
        HandleAnimation();
    }

    private void HandleAnimation()
    {
        bool isWalking = _animator.GetBool(_isWalingHash);
        bool isRunning = _animator.GetBool(_isRunningHash);

        if (_moveControl.IsMovePress && !isWalking)
        {
            _animator.SetBool(_isWalingHash,true);
        }
        else if(!_moveControl.IsMovePress && isWalking)
        {
            _animator.SetBool(_isWalingHash, false); 
        }
        
        if ((_moveControl.IsMovePress && _moveControl.IsRunPress) && !isRunning )
        {
            _animator.SetBool(_isRunningHash,true);
        }
        else if((!_moveControl.IsMovePress || !_moveControl.IsRunPress) && isRunning)
        {
            _animator.SetBool(_isRunningHash,false);
        }


    }
}
