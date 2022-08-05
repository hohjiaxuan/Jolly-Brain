using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class back2 : MonoBehaviour
{
	public GameObject Panel2;
	public GameObject Resume;
	
	
	public void hidepanel2()
	{
		 {
			Panel2.gameObject.SetActive (false);
			Resume.gameObject.SetActive (true);
		}
	}
}