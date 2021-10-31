using UnityEngine;

public class ObjectiveReceiver : MonoBehaviour
{
    public int Id;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Receiver"))
        {
            var obj = collision.collider.GetComponent<ObjectiveReceiver>();
            if (obj.Id == Id)
            {
                GameManager.S.Left--;
                if (GameManager.S.Left == 0)
                {
                    GameManager.S.Win();
                }
                Destroy(collision.collider.gameObject);
                Destroy(gameObject);
            }
        }
    }
}