using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramplate : MonoBehaviour
{
    public float jumpSpeed = 2.5f;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpSpeed;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpSpeed;
    }
}
