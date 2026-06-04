using JetBrains.Annotations;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;


public class CreateManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject elemental;
    [SerializeField] List<GameObject> objList = new List<GameObject>();
    [SerializeField] int count = 0;
    [SerializeField] int last;
    WaitForSeconds waitforseconds = new WaitForSeconds(5f);
    void Start()
    {
        
        for (int i = 0; i < 5; i++)
        {
            GameObject tree = Instantiate(elemental, transform);
            objList.Add(tree);
            tree.SetActive(false);
            tree.transform.position = new Vector3(-3 + (1.5f * i), 1, 1);
        }
        last = objList.Count;
        
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        //for (count = 0; count < objList.Count; count++)
        //{
        //    objList[count].SetActive(true);
        //    yield return new WaitForSeconds(5.0f);
        //}

        while (count < objList.Count)
        {
            objList[count++].SetActive(true);
            yield return waitforseconds;
        }

    }

}
