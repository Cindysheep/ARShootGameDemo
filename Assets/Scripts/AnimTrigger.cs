using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    [SerializeField] private Animator AstronautAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if(AstronautAnimator == null)
        {
            Debug.LogWarning("AstronautAnimator is not missing.");
            return;
        }
        if(other.gameObject.CompareTag("DroneOccObj"))
        {
            Debug.Log("Trigger entered by: " + other.gameObject.name);
            AstronautAnimator.SetBool("IsDrilling", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(AstronautAnimator == null)
        {
            Debug.LogWarning("AstronautAnimator is not missing.");
            return;
        }
        AstronautAnimator.SetBool("IsDrilling", false);

    }

}
