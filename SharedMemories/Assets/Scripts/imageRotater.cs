using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageRotater : MonoBehaviour
{
    public List<Sprite> picList;
	public Image img;

	private void Start()
	{
		InvokeRepeating("ChangeImg", 0, 1);
	}

	void ChangeImg()
	{
		int newIndex = Random.Range(0, picList.Count);

		img.sprite = picList[newIndex];
	}
}
