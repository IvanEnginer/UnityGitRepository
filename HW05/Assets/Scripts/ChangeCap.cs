using System.Collections.Generic;
using UnityEngine;

public class ChangeCap : MonoBehaviour
{
    public List<GameObject> CapList = new List<GameObject>();

    private void Start()
    {
        CapList[0].SetActive(true);
    }

    public void SetCap(int index)
    {
        for (int i = 0; i < CapList.Count; i++)
        {
            if (i == index)
            {
                CapList[i].SetActive(true);
            }
            else
            {
                CapList[i].SetActive(false);
            }
        }
    }
}
