using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    public TMP_Dropdown UserDropdown;
    public TMP_Dropdown VenueDropdown;

    public void ChangeScene() 
    { 
        string UserNumber = UserDropdown.value.ToString();
        string VenueNumber = VenueDropdown.value.ToString();

        if(UserNumber.Equals("1") && VenueNumber.Equals("0"))
        {
             SceneManager.LoadScene("Arena"); 
        }
        else if (UserNumber.Equals("0") && VenueNumber.Equals("0"))
        {
            SceneManager.LoadScene("Venue");
        }
         
    } 

    public void HomeScene() 
    { 
             SceneManager.LoadScene("Welcome");
    } 
}
