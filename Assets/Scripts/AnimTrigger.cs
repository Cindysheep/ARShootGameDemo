using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    [SerializeField] private Animator AstronautAnimator;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Astronaut") == false)
            return;
        Debug.Log("Trigger entered by: " + other.gameObject.name);
        AstronautAnimator.SetBool("IsDrilling", true);

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Astronaut") == false)
            return;
        AstronautAnimator.SetBool("IsDrilling", false);
    }

}
