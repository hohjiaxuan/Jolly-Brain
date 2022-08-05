using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question3 : MonoBehaviour
{
   

     [Header("Question3")]
   
	public GameObject boxScreen3 ;
 
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("boxQ3"))
        {
            //collectionSoundEffect.Play();
           
		   boxScreen3.SetActive(true);
            Time.timeScale = 1f;
        }

      
    }
}
