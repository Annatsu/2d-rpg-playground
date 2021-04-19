using System;
using UnityEngine;

[Serializable]
public class Entity : MonoBehaviour
{

    public enum EntityState
    {
        IDLE,
        MOVING,
        ATTACKING
    };

    [Header("General")]
    public string Name;
    public string Job;
    public int Level;
    public EntityState ActiveEntityState;

    [Header("Attributes")]
    public int Strength;
    public int Dexterity;
    public int Endurance;
    public int Intelligence;
    public int Willpower;
    public int Charisma;

    [Header("Stats")]
    public int MaxHP;
    public int MaxMP;
    protected int CurrentHP;
    protected int CurrentMP;

}
