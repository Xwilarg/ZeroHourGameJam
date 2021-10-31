using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private int _nextReceiver = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (GameManager.S.DidGameEnded) return;
        if (other.CompareTag("Receiver"))
        {
            var receiver = other.GetComponent<ObjectiveReceiver>();
            if (receiver.Order == _nextReceiver)
                _nextReceiver++;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (GameManager.S.DidGameEnded) return;
        if (collision.collider.CompareTag("Death"))
        {
            SceneManager.LoadScene("Main");
        }
    }
}