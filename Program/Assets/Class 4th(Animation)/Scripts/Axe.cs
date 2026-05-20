using UnityEngine;
using UnityEngine.UI;

public class Axe : MonoBehaviour
{
    public int strikes;
    public float proficiency;
    public void Attack(int count)
    {
        this.strikes += count;
        if (this.strikes % 10 == 0) 
        {
            Debug.Log("Critical");
        }
    }

    public void Defend(int defensive_power)
    {
        Debug.Log("Defend");
    }

    public void Throw(float experience)
    {
        if(proficiency < 100)
        {
            proficiency += experience;

            Debug.Log("Proficiency : "+ proficiency + "%");
        }
        else
        {
            Debug.Log("I have Mastered the skill");
        }
    }
}
