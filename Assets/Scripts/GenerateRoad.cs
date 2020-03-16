using System.Collections;
using UnityEngine;

public class GenerateRoad : MonoBehaviour
{
    private IEnumerator coroutine;
    public GameObject road;
    public float interval;

    void Start()
    {
        GameObject clone = Instantiate(road, new Vector3(0, 0, 0), Quaternion.identity);
        coroutine = WaitAndInstantiate(interval);
        StartCoroutine(coroutine);
    }

    private IEnumerator WaitAndInstantiate(float waitTime)
    {
        var inc = 10;
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            GameObject clone = Instantiate(road, new Vector3(0, 0, inc), Quaternion.identity);
            Destroy(clone, 10);
            print("Road generated");
            inc += 10;
        }
        
    }
}
