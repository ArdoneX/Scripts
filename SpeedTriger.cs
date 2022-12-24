using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
    // Start is called before the first frame update
}
