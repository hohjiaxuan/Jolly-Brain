using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class back4 : MonoBehaviour
{
	public GameObject Panel4;
	public GameObject Resume;
	
	
	public void hidepanel4()
	{
		 {
			Panel4.gameObject.SetActive (false);
			Resume.gameObject.SetActive (true);
		}
	}
}