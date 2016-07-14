using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotationAxes;

    void LateUpdate()
    {
        transform.rotation *= Quaternion.Euler(rotationAxes * Time.deltaTime);
    }
}
