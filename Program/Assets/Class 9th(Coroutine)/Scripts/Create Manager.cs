using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject elemental;
    [SerializeField] List<GameObject> objList = new List<GameObject>();
    [SerializeField] float timer = 0f;
    [SerializeField] int count = 0;
    void Start()
    {
        
        for (int i = 0; i < 5; i++)
        {
            GameObject tree = Instantiate(elemental, transform);
            objList.Add(tree);
            tree.SetActive(false);
            tree.transform.position = new Vector3(-3 + (1.5f * i), 1, 1);

        }
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(5.0f);
        Debug.Log("Stop_");
    }

}
