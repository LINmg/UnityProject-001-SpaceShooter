using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsreriodManage : MonoBehaviour
{
    public GameObject[] go = new GameObject[3];
    private GameObject go_clone;
    private Transform ts_Asreriod;
    private int numPer;
    // Use this for initialization
    void Start()
    {
        ts_Asreriod = gameObject.GetComponent<Transform>();
        StartCoroutine(RandomCreat());
    }

    IEnumerator RandomCreat()
    {
        yield return new WaitForSeconds(2.0f);
        while (true)
        {
            numPer = Random.Range(4, 6);
            for (int i = 0; i < numPer; i++)
            {
                Vector3 Start = new Vector3(Random.Range(-6f, 6f), 0f, 10);
                int index = Random.Range(0, 2);
                go_clone = Instantiate(go[index], Start, Quaternion.identity);
                go_clone.GetComponent<Transform>().SetParent(ts_Asreriod);
                yield return new WaitForSeconds(1f);
            }
            yield return new WaitForSeconds(2.0f);
        }
    }
}
