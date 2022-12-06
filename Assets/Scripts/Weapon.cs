using UnityEngine;

public class Weapon : MonoBehaviour
{
   [SerializeField]
   private Bullet _bullet;

   [SerializeField]
   private Transform _muzzle;

   [SerializeField] 
   private GameObject _gameObject;
   
   public  void Shoot(Vector3 hit)
   {
      var bullet = Instantiate(_bullet, _muzzle.position,_muzzle.rotation);
      bullet.Initialize(_gameObject.transform.forward);
   }
}
