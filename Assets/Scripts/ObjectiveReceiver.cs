using UnityEngine;

public class ObjectiveReceiver : MonoBehaviour
{
    public int Id;
    public bool Leader;

    private void OnCollisionEnter(Collision collision)
    {
        if (!Leader) return;
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