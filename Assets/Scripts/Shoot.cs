using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [Header("Firing Settings")]
    public float maxProjectileForce = 18000f;
    public float cooldown = 1f;

    [Header("Projectile Settings")]
    public GameObject projectilePrefab;
    public GameObject projectileSpawnPoint;

    Transform projectileSpawnTransform; //location to spawn projectiles
    bool canShoot = true;
    Animator anim;

    void Awake()
    {

        // projectileSpawnTransform = GameObject.Find("Prefabs/Projectile Spawn Point").transform;
        projectileSpawnTransform = projectileSpawnPoint.transform;

        // anim = GetComponent<Animator>();
    }

    public void FireProjectile()
    {
        if(!canShoot)
            return;
        
        GameObject go = Instantiate(projectilePrefab, projectileSpawnTransform.position, projectileSpawnTransform.rotation);
        Vector3 force = projectileSpawnTransform.forward * maxProjectileForce;
        go.GetComponent<Rigidbody>().AddForce(force);
        // if (anim != null)
        // {
        //     anim.SetTrigger("Fire");            
        // }

        canShoot = false;
        Invoke("CoolDown", cooldown);
    }

    private void CoolDown()
    {
        canShoot = true;
    }

    public void OnARButtonClicked()
    {
        Debug.Log("AR Button Clicked!");
    }
}
