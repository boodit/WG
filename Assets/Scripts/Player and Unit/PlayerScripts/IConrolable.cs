using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConrolable
{
   const float _runSpeed = 3;
   const float _speed = 1;
   const float _gravity = 9.8f;
   public void Move();
}
