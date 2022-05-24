using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    public GameObject panel;
    public GameObject cursor;

    public void Update()
    {
        if(Input.GetKeyDown("i"))
        {
            panel.SetActive(false);
            cursor.SetActive(true);
        }
    }
    public void buttonMethod()
    {
        Debug.Log("done");
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
        cursor.SetActive(false);
    }

    

}
