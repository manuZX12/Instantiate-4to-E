using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
   int CloneAmount;
    public Text UserCloneAmount;


    public void MultiInstantiate()
    {
        if (UserCloneAmount.text != "")
        {
            CloneAmount = int.Parse(UserCloneAmount.text);
        }
        
        for(int i = 0; i<CloneAmount; i++)
        {
            Instantiate(objectToClone);
        }
    }
}
