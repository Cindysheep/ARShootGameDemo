using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
        {
            // 命中 Astronaut
            if (collision.gameObject.CompareTag("Astronaut"))
            {
                Debug.Log("Projectile hit an Astronaut!");
                Destroy(collision.gameObject); // 摧毁 Astronaut
                Destroy(gameObject);           // 摧毁子弹（推荐）
            }
        }
}
