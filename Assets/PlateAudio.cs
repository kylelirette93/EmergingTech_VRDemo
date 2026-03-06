using UnityEngine;

public class PlateAudio : MonoBehaviour
{
    [SerializeField] private AudioSource plateAudioSource;
    [SerializeField] private AudioDataSO plateDataSO;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 1f)
        {
            plateDataSO.Play(plateAudioSource);
        }
    }
}
