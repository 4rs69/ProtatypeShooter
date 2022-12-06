using System;
using UnityEngine;

public class EnemyHarassingPlayer : MonoBehaviour
{
    [SerializeField]
    private float _speedMove = 1f;
 
    [SerializeField]
    private Transform _player;

    private EnemyAnimationController _enemyAnimationController;
    private void Start()
   {
       _player = GameObject.FindGameObjectWithTag("Player").transform;
       _enemyAnimationController = GetComponent<EnemyAnimationController>();

   }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _speedMove * Time.deltaTime);
        transform.LookAt(_player.transform, Vector3.up);
        
        _enemyAnimationController.WalkingEnemy();
    }
}
