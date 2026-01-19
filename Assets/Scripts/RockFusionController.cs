using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RockFusionController : MonoBehaviour
{
    public GameObject Rock;
    public Canvas RockUI;


    private void OnParticleSystemStopped()
    {
        Debug.Log("Fusion effect completed.");
        Rock.SetActive(true);
        RockUI.gameObject.SetActive(true);
    }
}
