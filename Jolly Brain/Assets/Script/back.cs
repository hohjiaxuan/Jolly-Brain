using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class back : MonoBehaviour
{
	public GameObject Panel1;
	public GameObject Resume;
	
	
	public void hidepanel1()
	{
		 {
			Panel1.gameObject.SetActive (false);
			Resume.gameObject.SetActive (true);
		}
	}
}