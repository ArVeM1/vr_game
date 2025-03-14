using UnityEngine;

public class SphereInitialPosition : MonoBehaviour
{
    [HideInInspector] public Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position; 
    }
}
