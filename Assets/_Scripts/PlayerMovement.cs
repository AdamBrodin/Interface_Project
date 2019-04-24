using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Developed by Adam Brodin
 * https://github.com/AdamBrodin
 */

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour, IMoveable
{
    #region Variables
    public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }
    [SerializeField]
    private float moveSpeed;
    private Rigidbody rgbd;
    #endregion

    private void Awake()
    {
        rgbd = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rgbd.velocity = new Vector3(moveInput.x * moveSpeed, 0, moveInput.z * moveSpeed);
    }


    // Make sure the function/variable values remain the same
    private void OnValidate()
    {
        MoveSpeed = moveSpeed;
    }
}
