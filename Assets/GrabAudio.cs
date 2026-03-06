using UnityEngine;

public class GrabAudio : MonoBehaviour
{
    [SerializeField] private AudioSource grabAudioSource;
    [SerializeField] private AudioDataSO grabAudioData;

    private void OnTriggerEnter(Collider other)
    {
        grabAudioData.Play(grabAudioSource);
    }
}
