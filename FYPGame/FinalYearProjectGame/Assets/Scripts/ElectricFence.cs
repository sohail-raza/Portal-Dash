using UnityEngine;
using System.Collections;

public class ElectricFence : MonoBehaviour {

	public float timetoReactivate;

	void Start()
	{
		InvokeRepeating("StateSwitcher", 0.0f, timetoReactivate); // default startup
	}

	void StateSwitcher()
	{
		gameObject.SetActive(!gameObject.activeSelf);
	}

	}


