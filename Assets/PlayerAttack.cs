using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using NaughtyAttributes;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] InputActionReference _onAttack;
    // Start is called before the first frame update
    void Start()
    {

        _onAttack.action.started += OnAttack; ;

    }

    private void OnAttack(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void OnDestroy()
    {
        _onAttack.action.started -= OnAttack;
    }
}
