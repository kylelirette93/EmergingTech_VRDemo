using UnityEngine;

public class XRPhysicsWakeup : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        if (rb != null)
        {
            rb.WakeUp();
            rb.AddForce(Vector3.up * 0.0001f, ForceMode.Impulse);
        }

    }
}
