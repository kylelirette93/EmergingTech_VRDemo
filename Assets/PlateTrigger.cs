using UnityEngine;

public class PlateTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cookable"))
        {
            other.gameObject.transform.SetParent(this.transform, true);
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
