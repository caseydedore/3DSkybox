using UnityEngine;


public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    private float copyFactor = 1f;
    [SerializeField]
    private Transform target;

    private Vector3 targetLastPosition = Vector3.zero;
    private float targetTravelDistance = 0f;


    void Start()
    {
        targetLastPosition = target.position;
    }

    void Update()
    {
        targetTravelDistance = Vector3.Distance(target.position, targetLastPosition);

        transform.position = transform.position + ((target.position - targetLastPosition) * copyFactor);

        targetLastPosition = target.position;
    }
}
