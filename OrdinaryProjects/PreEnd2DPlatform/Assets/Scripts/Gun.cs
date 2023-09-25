using UnityEngine;

public class Gun : MonoBehaviour
{
    private const byte BulletSpeed = 10;

    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private GameObject bulletPrefabs;
    [SerializeField] private InputPlayerControll firePress;


    private void Update()
    {
        if (firePress.ReturnFireButtonPressed())
        {
            var bullet = Instantiate(bulletPrefabs, bulletSpawn.position, bulletSpawn.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawn.right * BulletSpeed;  
        }
    }
}
