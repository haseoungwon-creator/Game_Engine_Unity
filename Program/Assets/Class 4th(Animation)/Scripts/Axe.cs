using UnityEngine;
using UnityEngine.UI;

public class Axe : MonoBehaviour
{

    public void Attack(int count)
    {
        Debug.Log("Attack");
        
        if (count > 10)
        {
            Debug.Log("Critical");
        }
    }

    public void Defend(int defensive_power)
    {
        Debug.Log("Defend");
    }

    public void Throw(int throw_damage)
    {
        Debug.Log("Throw");
    }
}
