/*===============================================================================
Copyright (c) 2016 PTC Inc. All Rights Reserved.
 
Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
===============================================================================*/
using UnityEngine;
using System.Collections;

public class NavigationHandler : MonoBehaviour
{
    #region MONOBEHAVIOUR_METHODS

    void Update ()
    {
        #if (UNITY_EDITOR || UNITY_ANDROID)
        if (Input.GetKeyUp (KeyCode.Escape)) {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #elif UNITY_ANDROID
            // On Android, the Back button is mapped to the Esc key
            Application.Quit();
            #endif
        }

        #endif // UNITY_EDITOR || UNITY_ANDROID
    }

    #endregion // MONOBEHAVIOUR_METHODS
}
