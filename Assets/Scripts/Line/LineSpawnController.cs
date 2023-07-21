using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSpawnController : MonoBehaviour
{
    [SerializeField] GameObject lastLineObject;
    [SerializeField] GameObject linePrefab;
    GameObject newLineObject;
    [SerializeField] float spawnTime;

    void Start()
    {
        StartCoroutine(nameof(CreateNewLineObject));
        
    }

    IEnumerator CreateNewLineObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            newLineObject = Instantiate(linePrefab, lastLineObject.transform.GetChild(0).
            transform.GetChild(0).GetComponent<Transform>().position, transform.rotation);
            lastLineObject = newLineObject;
        }
    }
}
