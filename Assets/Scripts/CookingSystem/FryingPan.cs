using UnityEngine;

public class FryingPan : MonoBehaviour, IHeatable
{
    bool isOnBurner = false;
    [SerializeField] private Rigidbody panRb;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cookable"))
        {
            var joint = other.gameObject.AddComponent<ConfigurableJoint>();
            joint.connectedBody = panRb;
            joint.xMotion = ConfigurableJointMotion.Locked;
            joint.yMotion = ConfigurableJointMotion.Locked;
            joint.zMotion = ConfigurableJointMotion.Locked;
            joint.angularXMotion = ConfigurableJointMotion.Locked;
            joint.angularYMotion = ConfigurableJointMotion.Locked;
            joint.angularZMotion = ConfigurableJointMotion.Locked;


            //other.gameObject.transform.SetParent(transform, true);
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

            Destroy(other.GetComponent<ConfigurableJoint>());
        }
    }

    public void SetOnBurner(bool onBurner)
    {
        isOnBurner = onBurner;
    }
}
