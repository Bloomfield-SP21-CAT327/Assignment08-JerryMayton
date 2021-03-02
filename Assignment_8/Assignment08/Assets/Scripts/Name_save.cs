using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Name_save : MonoBehaviour
{
    public InputField textBox;

    public void clickkSaveButton() {
        PlayerPrefs.SetString("name", textBox.text);
        Debug.Log("Your name is " + PlayerPrefs.GetString("name"));

        SceneManager.LoadScene("SecondScene");
    }
}
