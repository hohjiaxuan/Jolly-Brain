using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question2 : MonoBehaviour
{
   

     [Header("Question2")]
   
	public GameObject boxScreen2 ;
 
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("boxQ2"))
        {
            //collectionSoundEffect.Play();
           
		   boxScreen2.SetActive(true);
            Time.timeScale = 1f;
        }

      
    }
}
