using UnityEngine;


public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    private float copyFactor = 1f;
    [SerializeField]
    private Transform target;

    private Vector3 targetLastPosition = Vector3.zero;


    void Start()
    {
        targetLastPosition = target.position;
    }

    void Update()
    {
        transform.position = transform.position + ((target.position - targetLastPosition) * copyFactor);

        targetLastPosition = target.position;
    }
}
