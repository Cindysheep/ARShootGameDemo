using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerInteraction : MonoBehaviour
{
    [SerializeField] private Animator pikachuAnimator;
    [SerializeField] 
    public GameObject Pikachu;
    public GameObject Jirachi;
    public GameObject Charizard;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.gameObject.name);
        Pikachu.SetActive(false);
        Charizard.SetActive(false);
        Jirachi.SetActive(true);
        // pikachuAnimator.SetBool("IsInteracting", true);

    }

    private void OnTriggerExit(Collider other)
    {
        Charizard.SetActive(true);
        Pikachu.SetActive(true);
        Jirachi.SetActive(false);

        // pikachuAnimator.SetBool("IsInteracting", false);
    }
}
