using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Shoot shooter;
    [SerializeField] 
    public GameObject Astronaut;
    public GameObject Drone;




    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.gameObject.name);
        if (shooter != null)
            shooter.FireProjectile();
    }

    private void OnTriggerExit(Collider other)
    {

    }
}
