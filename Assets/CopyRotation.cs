using UnityEngine;
using System.Collections;

public class CopyRotation : MonoBehaviour
{
    [SerializeField]
    private Transform target;

	void Update ()
    {
        transform.rotation = target.rotation;
	}
}
