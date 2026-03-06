using UnityEngine;

public class PlateTrigger : MonoBehaviour
{
    [SerializeField] Rigidbody plateRb;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cookable"))
        {
            var joint = other.gameObject.AddComponent<ConfigurableJoint>();
            joint.connectedBody = plateRb;
            joint.xMotion = ConfigurableJointMotion.Locked;
            joint.yMotion = ConfigurableJointMotion.Locked;
            joint.zMotion = ConfigurableJointMotion.Locked;
            joint.angularXMotion = ConfigurableJointMotion.Locked;
            joint.angularYMotion = ConfigurableJointMotion.Locked;
            joint.angularZMotion = ConfigurableJointMotion.Locked;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cookable"))
        {
            Destroy(other.GetComponent<ConfigurableJoint>());
        }
    }
}
