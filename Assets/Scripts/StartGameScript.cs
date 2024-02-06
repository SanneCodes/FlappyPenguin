using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Button clicked");
        SceneManager.LoadScene("MainGame");
    }
}
