using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveable
{
    float MoveSpeed { get; set; }
    void Move();
}
