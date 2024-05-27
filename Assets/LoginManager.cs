using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LoginManager : MonoBehaviour
{
    public string contraseña_god;
    public InputField contra; 
    
  
      public void CHEKEARCONTRASEÑA()
      {
         if (contraseña_god == contra.text)
         {
            Debug.Log("acces granted");
         }
         else 
         {
            Debug.Log("acces denied"); 
         }
      }

}
