using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    /* 
    Our panel generally innot visible when we run the game. but we have button which make this panel
    open and close. Here is a method for that feature. By default we deactive panel's visibility by default and
    with this script and with pressing the button, panel will be open.
    this method is for toggle panel. It means user can open and close the panel by button.
    */

    public GameObject panel;
    public void OpenPanel()
    {
        if (panel != null)
        {
            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);   
        }
    }
}
