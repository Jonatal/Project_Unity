using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnField : MonoBehaviour
{
    public GameObject TujuanPanel;

    bool UnHide;
    // Start is called before the first frame update
    public void GantiPanel()
    {
        if (TujuanPanel == true){

            UnHide = TujuanPanel.activeSelf;
            TujuanPanel.SetActive(!UnHide);
        }
        
    }
}
