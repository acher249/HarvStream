using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(this.gameObject.transform.rotation.x, this.gameObject.transform.rotation.y + 50f, this.gameObject.transform.rotation.z, Space.Self);
    }
}
