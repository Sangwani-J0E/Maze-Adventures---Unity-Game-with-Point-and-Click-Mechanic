using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Link : MonoBehaviour
{
     void Start()
    {   
        Advertisement.Initialize("5492349");
    }
    public void link(){
        Application.OpenURL("https://gofund.me/240ec31a");
    }
    public void ShowAd(){
    Advertisement.Show("Interstitial_Android");
        Debug.Log("You're watching an AD!!!");
    }
}
