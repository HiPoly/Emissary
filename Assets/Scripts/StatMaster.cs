using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatMaster : MonoBehaviour
{
    //MechVars1
    //for now armour features will int 0 - 4 to represent colour states
    public int legL = 4;
    public int legR = 4;
    public int chassis = 4;
    public int storageL = 4;
    public int storageR = 4;
    public int storageB = 4;
    //MechVars2
    //Non-unique component features range from 0 - 2
    public int speed;
    public int vision;
    public int durability;
    //PilotVars
    //maxHealth is reduced by other vars from 0-30
    public int startHealth = 100;
    public int maxHealth = 100;
    public int currentHealth;
    public int stress = 0;
    public int hunger = 0;
    public int thirst = 0;

    // Update is called once per frame
    void Update()
    {
        maxHealth = startHealth - (stress + hunger + thirst);
        //reduce health if at max health
        if (currentHealth > maxHealth){
            currentHealth = maxHealth;
        }
    }
}
