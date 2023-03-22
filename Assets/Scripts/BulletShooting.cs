using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooting : MonoBehaviour
{
    private PlayerControl playerControlScript;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    private float nextShot = 0.15f;
    private float fireDelay = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        playerControlScript = GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextShot)
        {
            Shoot();
            nextShot = Time.time + fireDelay;
        }
    }

    void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(bulletSpawnPoint.up * bulletSpeed, ForceMode2D.Impulse);
    }
}
