using UnityEngine;

public class Burner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Heatable"))
        {
            IHeatable heatable = other.GetComponent<IHeatable>();
            heatable?.SetOnBurner(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Heatable"))
        {
            IHeatable heatable = other.GetComponent<IHeatable>();
            heatable?.SetOnBurner(false);
        }
    }
}

