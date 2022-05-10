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
   
}
