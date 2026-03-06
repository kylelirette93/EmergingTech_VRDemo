using UnityEngine;

public class Lid : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioSource trashCanAudioSource;
    [SerializeField] private AudioDataSO trashCanDataSO;
    [SerializeField] private AudioDataSO metalThumpDataSO;

    private float minImpactVelocity = 1.0f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > minImpactVelocity)
        {
            if (collision.gameObject.CompareTag("Trash"))
            {
                trashCanDataSO.Play(trashCanAudioSource);
            }
            else
            {
                metalThumpDataSO.Play(trashCanAudioSource);
            }
        }
    }
}
