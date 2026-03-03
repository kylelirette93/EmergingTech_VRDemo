using UnityEngine;

public class Plate : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cookable"))
        {
            collision.gameObject.transform.SetParent(this.transform, true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cookable"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
