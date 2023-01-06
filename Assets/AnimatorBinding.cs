using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class AnimatorBinding : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] InputActionReference _move;
    [SerializeField] InputActionReference _attack;
    [SerializeField] EntityHealth _entity;

    private void Start()
    {
        _entity.TakeDmg += PlayerGetHit;
        _move.action.started += PlayerMove;
        _move.action.performed += PlayerMove;
        _move.action.canceled += PlayerStop;
        _attack.action.started += PlayerAttack;
        _move.action.canceled += PlayerStop;

    }
    private void OnDestroy()
    {
        _entity.TakeDmg -= PlayerGetHit;
        _move.action.started -= PlayerMove;
        _move.action.performed -= PlayerMove;
        _move.action.canceled -= PlayerStop;

    }

    public void PlayerMove(InputAction.CallbackContext obj)
    {
        _animator.SetBool("Walking", true);
    }
    public void PlayerStop(InputAction.CallbackContext obj)
    {
        _animator.SetBool("Walking", false);
    }
    public void PlayerAttack(InputAction.CallbackContext obj)
    {
        _animator.SetBool("Attack", true);
    }
    public void PlayerStopAttack(InputAction.CallbackContext obj)
    {
        _animator.SetBool("Attack", false);
    }

    public void PlayerGetHit()
    {
        _animator.SetBool("GetHit", true);
    }
    public void PlayerStopHit()
    {
        _animator.SetBool("GetHit", false);
    }

}
