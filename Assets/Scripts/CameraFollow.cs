using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject _follow;

    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _follow.transform.position;
    }

    private void Update()
    {
        transform.position = _offset + _follow.transform.position;
    }
}