using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (GameManager.S.DidGameEnded) return;
        if (collision.collider.CompareTag("Death"))
        {
            SceneManager.LoadScene("Main");
        }
    }
}