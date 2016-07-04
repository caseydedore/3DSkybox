using UnityEngine;
using System.Collections;

public class CopyRotation : MonoBehaviour
{
    [SerializeField]
    private Transform target;

	void LateUpdate ()
    {
        transform.rotation = target.rotation;
	}
}
