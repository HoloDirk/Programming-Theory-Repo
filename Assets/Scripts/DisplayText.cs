using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class DisplayText : MonoBehaviour
{
    public Text objectText;
    public InputField display;

    // Start is called before the first frame update
    void Start()
    {
        objectText.text = PlayerPrefs.GetString("user_name"); 
    }

    public void Create()
    {
        objectText.text = display.text;
        PlayerPrefs.SetString("user_name", objectText.text);
        PlayerPrefs.Save();
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}