using UnityEngine;

public class PlateTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cookable"))
        {
            other.transform.SetParent(transform, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cookable"))
        {
            other.gameObject.transform.SetParent(null);
        }
    }
}
