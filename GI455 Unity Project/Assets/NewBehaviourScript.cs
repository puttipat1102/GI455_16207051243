using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public string inputword;
    public GameObject inputto;
    public GameObject Field;

    //Data 
    public string[] dataentry;
    //public string[] Dataentry = {"Nivea" , "YaKult" , "Glade" , "Water" , "Vivo" , "Candy" , "Hdmi" , "Spin"}

    public void dataroom()
    {
        inputword = inputto.GetComponent<InputField>().text;
        if (dataentry.Contains(inputword)) 
        {
            inputto.GetComponent<InputField>().text =  "<color=#00328A>" + inputword + "</color> Is Found";
            
        }
        else
        {
            inputto.GetComponent<InputField>().text =   "<color=#8A0000>" + inputword + "</color> Is Not Found" ;
        }



    }
}
 