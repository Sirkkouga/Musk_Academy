using UnityEngine;

public class CelestialBody : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public float orbitSpeed = 10f;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        if (transform.parent != null){
            transform.RotateAround(transform.parent.position, Vector3.up, orbitSpeed * Time.deltaTime);
            Vector3 orbitDirection = Vector3.Cross(Vector3.up, transform.position - transform.parent.position);
            Debug.DrawRay(transform.position, orbitDirection, Color.red);
        }
    }
}
