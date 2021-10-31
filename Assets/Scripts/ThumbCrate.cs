using UnityEngine;

public class ThumbCrate : MonoBehaviour
{
    private AudioSource _audio;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _audio?.Play();
    }
}