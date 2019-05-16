using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    /* this line of coe is a simplest way to keep our background music countinuable when player
    switch between scenes. 
    */

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject); 
    }
}
