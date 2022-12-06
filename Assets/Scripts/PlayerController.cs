using System;
using UnityEngine;

[RequireComponent(typeof(PlayerAnimationController))]
[RequireComponent(typeof(HealthController))]
[RequireComponent(typeof(PlayerMoveController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private CameraController _camera;
    
    private PlayerMoveController _playerMove;
    private HealthController _healthController;
    private PlayerAnimationController _playerAnimation;
    
    private void Awake()
    {
        _playerAnimation = GetComponent<PlayerAnimationController>();
        _playerMove = GetComponent<PlayerMoveController>();
        _healthController = GetComponent<HealthController>();
        _healthController.Died += OnDied;
        
    }
    
    private void OnDestroy()
    {
        if (_playerAnimation != null)
        {
            _healthController.Died -= OnDied;
        }
    }

    private void OnDied()
    {
        _playerAnimation.IsDied();
        _playerMove.enabled = false;
        _camera.enabled = false;
    }
}
