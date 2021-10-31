using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Direction _currDir = Direction.None;

    private AudioSource _audio;
    [SerializeField]
    private AudioClip[] _gravityClips;

    [SerializeField]
    private GameObject _victory;

    public bool DidGameEnded { set; get; } = false;

    public static GameManager S;

    public void Win()
    {
        DidGameEnded = true;
        _victory.SetActive(true);
    }

    private void Awake()
    {
        S = this;
    }

    private enum Direction
    {
        None, Up, Down, Left, Right
    }

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void PlayGravity()
    {
        _audio.clip = _gravityClips[Random.Range(0, _gravityClips.Length)];
        _audio.Play();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (_currDir != Direction.Up) Physics.gravity = Vector3.up;
            else Physics.gravity += Vector3.up;
            _currDir = Direction.Up;
            PlayGravity();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (_currDir != Direction.Down) Physics.gravity = Vector3.down;
            else Physics.gravity += Vector3.down;
            _currDir = Direction.Down;
            PlayGravity();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (_currDir != Direction.Right) Physics.gravity = Vector3.right;
            else Physics.gravity += Vector3.right;
            _currDir = Direction.Right;
            PlayGravity();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (_currDir != Direction.Left) Physics.gravity = Vector3.left;
            else Physics.gravity += Vector3.left;
            _currDir = Direction.Left;
            PlayGravity();
        }
    }
}
