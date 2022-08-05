using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question4 : MonoBehaviour
{
   

     [Header("Question4")]
   
	public GameObject boxScreen4 ;
 
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("boxQ4"))
        {
            //collectionSoundEffect.Play();
           
		   boxScreen4.SetActive(true);
            Time.timeScale = 1f;
        }

      
    }
}
