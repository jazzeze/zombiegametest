using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager Instance { get; set;  }

    public AudioSource playerChannel;
    public AudioClip playerHurt;
    public AudioClip playerDie;

    public AudioClip gameOverMusic;

    private void Awake()
    {
        if (Instance != null && Instance != this )
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
}
