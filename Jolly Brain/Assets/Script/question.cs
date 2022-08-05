using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question : MonoBehaviour
{
   

     [Header("Question")]
    public GameObject boxScreen1 ;
	
 
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("boxQ"))
        {
            //collectionSoundEffect.Play();
           boxScreen1.SetActive(true);
		  
            Time.timeScale = 1f;
        }

      
    }
}
