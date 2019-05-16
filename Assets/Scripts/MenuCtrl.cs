using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour
{
    /* This line code is when user click on menu button on the screen, application
    can load different scene. 
    This method is general can can be use in different parts of the game. because we do not
    use specific scene name but developer can write any scene name that want to switch to.   
    */

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
