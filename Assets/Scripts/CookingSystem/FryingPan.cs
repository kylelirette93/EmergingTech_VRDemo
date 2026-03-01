using UnityEngine;

public class FryingPan : MonoBehaviour, IHeatable
{
    bool isOnBurner = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cookable"))
        {
            other.gameObject.transform.SetParent(this.transform, true);
            if (isOnBurner)
            {
                ICookable cookable = other.GetComponent<ICookable>();
                if (cookable != null)
                {
                    cookable.Cook();
                }
            }
            else
            {
                ICookable cookable = other.GetComponent<ICookable>();
                if (cookable != null)
                {
                    cookable.StopCooking();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cookable"))
        {
            ICookable cookable = other.GetComponent<ICookable>();
            if (cookable != null)
            {
                cookable.StopCooking();
            }
        }
    }

    public void SetOnBurner(bool onBurner)
    {
        isOnBurner = onBurner;
    }
}
