using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceAnimSetter : MonoBehaviour
{
    public enum DanceType
    {
        twerk,handsup,step,headbang, hiphop,snake
    }

    void Start()
    {
        int danceType = Random.Range(0, 5);

		GetComponent<Animator>().SetTrigger(((DanceType)danceType).ToString());
    }
}
