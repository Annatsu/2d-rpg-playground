using System;
using UnityEngine;

[Serializable]
public class Entity
{

    [Header("General")]
    public string Name;
    public string Job;
    public int Level;

    [Header("Attributes")]
    public int Strength;
    public int Dexterity;
    public int Endurance;
    public int Intelligence;
    public int Willpower;
    public int Charisma;

    [Header("Stats")]
    public int MaxHP;
    public int CurrentHP;
    public int MaxMP;
    public int CurrentMP;

}
