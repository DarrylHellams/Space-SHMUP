using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this is an enum of the various possible weapon types
/// it also includes a "shield" type to allow a shield power-up
/// items marked [NI] below are not implemented in the IGDPD book
/// </summary>

public enum WeaponType
{
    none, //the default / no weapon
    blaster, //a simple blaster
    spread, //two shots simultaneously
    phaser, //[NI] shots that move in waves
    missile, //[NI] homing missiles
    laser, //[NI] damage over time
    shield //raise shieldLevel
}

/// <summary>
/// the weapon definition class allows you to set the properties
/// of a specific weapon in the Inspector. the main class has 
/// an array of weapon definitions that make this possible
/// </summary>

[System.Serializable]
public class WeaponDefinition
{
    public WeaponType type = WeaponType.none;
    public string letter;
    public Color color = Color.white;
    public GameObject projectilePrefab;
    public Color projectileColor = Color.white;
    public float damageOnHit = 0;
    public float continuousDamage = 0;
    public float delayBetweenShots = 0;
    public float velocity = 20;
}

public class Weapon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
