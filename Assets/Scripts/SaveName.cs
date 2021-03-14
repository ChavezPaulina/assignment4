using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveName : MonoBehaviour
{
    public InputField textbox;

    public void clickSaveButton()
    {
        PlayerPrefs.SetString("name", textbox.text);
        Debug.Log("your name is" + PlayerPrefs.GetString("name"));
    }
}
