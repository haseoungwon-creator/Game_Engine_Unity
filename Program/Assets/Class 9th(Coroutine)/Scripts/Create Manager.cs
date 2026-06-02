using NUnit.Framework;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject elemental;
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            GameObject tree= Instantiate(elemental, transform);
            tree.transform.position = new Vector3 (-3 + (1.5f * i), 1,1);
            
        }
    }

}
