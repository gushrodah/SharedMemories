using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserBehavior : MonoBehaviour
{
	public GameObject toEnable;
	public float flashRate = .25f;
	public Vector2 rotRange;
	private void Start()
	{
		InvokeRepeating("AdjustLaser", 0, flashRate);
	}

	void AdjustLaser()
	{
		toEnable.SetActive(!toEnable.activeInHierarchy);

		int newRot = Random.Range((int)rotRange.x, (int)rotRange.y);
		transform.eulerAngles = new Vector3(newRot, 0, 0);
	}
}
