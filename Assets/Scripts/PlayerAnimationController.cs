using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator _animator;
    
    private static readonly int WalkingFront = Animator.StringToHash("WalkingFront");
    private static readonly int WalkingBack = Animator.StringToHash("WalkingBack");
    private static readonly int WalkingRight = Animator.StringToHash("WalkingRight");
    private static readonly int WalkingLeft = Animator.StringToHash("WalkingLeft");
    private static readonly int Run = Animator.StringToHash("Run");
    private static readonly int Jump = Animator.StringToHash("Jump");
    private static readonly int Shoot = Animator.StringToHash("Shoot");
    private static readonly int Dead = Animator.StringToHash("Dead");

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void WalkingAnimation()
    {
        _animator.SetBool(WalkingFront, Input.GetKey(KeyCode.W));
        _animator.SetBool(WalkingBack, Input.GetKey(KeyCode.S));
        _animator.SetBool(WalkingRight, Input.GetKey(KeyCode.D));
        _animator.SetBool(WalkingLeft, Input.GetKey(KeyCode.A));
    }

    public void RunAnimation()
    {
        _animator.SetBool(Run, Input.GetKey(KeyCode.LeftShift));
    }
    
    public void JumpAnimation()
    {
        _animator.SetBool(Jump,Input.GetKeyDown(KeyCode.Space));
    }

    public void ShootingAnimation()
    {
        _animator.SetBool(Shoot,Input.GetMouseButtonDown(0));
    }

    public void IsDied()
    {
        _animator.SetTrigger(Dead);
    }
    
}
