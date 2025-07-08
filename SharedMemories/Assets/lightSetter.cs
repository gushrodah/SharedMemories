using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSetter : MonoBehaviour
{
	[SerializeField] Material yellowMat, greenMat, blueMat, purpleMat;
	[SerializeField] Light light;
	[SerializeField] MeshRenderer rend;

	private void Start()
	{
		InvokeRepeating("ChangeColor", 0, 1);
	}

	void ChangeColor()
	{
		int color = Random.Range(0, 4);

		if (color == 0)
		{
			light.color = Color.yellow;
			rend.sharedMaterial = yellowMat;
		}
		else if (color == 1)
		{
			light.color = Color.green;
			rend.sharedMaterial = greenMat;
		}
		else if (color == 2)
		{
			light.color = Color.cyan;
			rend.sharedMaterial = blueMat;
		}
		else if (color == 3)
		{
			light.color = Color.magenta;
			rend.sharedMaterial = purpleMat;
		}
	}

}
