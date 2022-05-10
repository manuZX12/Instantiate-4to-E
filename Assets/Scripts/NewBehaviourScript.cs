using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text txtUserName;

    public void showgreeting()
    {
        Debug.Log("Hola " + txtUserName.text);
    }
    public void ShowDouble()
    {
        Debug.Log(int.Parse(txtUserName.text) * 2);
    }
}
