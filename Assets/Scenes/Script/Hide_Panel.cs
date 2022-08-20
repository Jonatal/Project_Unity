using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_Panel : MonoBehaviour
{
    public GameObject ListPanel;

    public void ShowHideMenu()
    {
        if(ListPanel != null)
        {
            Animator animator = ListPanel.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("Run_Rule");
                animator.SetBool("Run_Rule", !isOpen);
            } 
        }
    }

}
