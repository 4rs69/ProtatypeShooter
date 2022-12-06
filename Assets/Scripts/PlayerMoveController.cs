using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3;

    [SerializeField]
    private float _speedValue = 3;

    [SerializeField]
    private float _speedAcceleration = 5;

    private PlayerAnimationController _animation;

    private void Awake()
    {
        _animation = GetComponent<PlayerAnimationController>();
    }

    private void Update()
    {
        _speed = Input.GetKey(KeyCode.LeftShift) ? _speedAcceleration : _speedValue;
        
        var vertical = Input.GetAxis("Vertical"); // A D
        var horizontal = Input.GetAxis("Horizontal"); // W S

        var move = (transform.forward * vertical + transform.right * horizontal).normalized;
        var moveDelta = move * _speed * Time.deltaTime;
        transform.Translate(moveDelta, Space.World);
        
        _animation.WalkingAnimation();
        _animation.RunAnimation();
        _animation.JumpAnimation();
        _animation.ShootingAnimation();
    }
}
