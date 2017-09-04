using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit : MonoBehaviour {
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
