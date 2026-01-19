using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockOnTriggerInteraction : MonoBehaviour
{
    [SerializeField] 
    public GameObject Water;
    public GameObject Lava;
    public GameObject Rock;
    // public GameObject EffectObject;
    public ParticleSystem FusionEffect;
    public Canvas RockUI;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.gameObject.name);
        //Disable water and lava
        Water.SetActive(false);
        Lava.SetActive(false);

        //Enable and play effect
        FusionEffect.gameObject.SetActive(true);
        FusionEffect.Play();

        // if (FusionEffect.isStopped)
        // {
        //     RockUI.enabled = true;
        //     Rock.SetActive(true);
        // }
        // WaterAnimator.SetBool("IsInteracting", true);

    }



    private void OnTriggerExit(Collider other)
    {
        Lava.SetActive(true);
        Water.SetActive(true);
        Rock.SetActive(false);
        RockUI.gameObject.SetActive(false);

        // WaterAnimator.SetBool("IsInteracting", false);
    }
}
