using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class back3 : MonoBehaviour
{
	public GameObject Panel3;
	public GameObject Resume;
	
	
	public void hidepanel3()
	{
		 {
			Panel3.gameObject.SetActive (false);
			Resume.gameObject.SetActive (true);
		}
	}
}