using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this line is to make sure there is a button attached.
[RequireComponent(typeof(Button))]
public class ClickSound : MonoBehaviour
{
    // Where we passing sounds we want our buttons to make.
    public AudioClip sound;

    // Get accessor for returning button component on the game object.
    private Button button { get { return GetComponent<Button>(); } }

    // Get accessor for returning Audio source component on the game object.
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    // Start is called before the first frame update
    void Start()
    {
        // Adding audio source component to the game object and we can call the source that we created before.
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;

        // this line is to make sure function is call when the button is clicked.
        button.onClick.AddListener(() => PlaySound());
    }

    void PlaySound()
    {
        source.PlayOneShot(sound);
    }

}
