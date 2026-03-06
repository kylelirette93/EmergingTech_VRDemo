using UnityEngine;

[CreateAssetMenu(fileName = "AudioData", menuName = "ScriptableObjects/AudioDataSO", order = 1)]
public class AudioDataSO : ScriptableObject
{
    public AudioClip audioClip;
    public float volume = 1f;
    public Vector2 pitchRange = new Vector2(1f, 1f);
    public bool isLooping = false;

    public void Play(AudioSource source)
    {
        source.clip = audioClip;
        source.volume = volume;
        source.pitch = Random.Range(pitchRange.x, pitchRange.y);
        source.loop = isLooping;
        source.Play();
    }
}
