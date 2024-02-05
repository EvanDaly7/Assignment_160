using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private string EnemyName;
    [SerializeField] private string EnemyDescription;
    [SerializeField] private float EnemyHealth;
    [SerializeField] private float EnemyDamage;
    [SerializeField] private float EnemySpeed;

    public string EnemyName1 { get => EnemyName; set => EnemyName = value; }
    public string EnemyDescription1 { get => EnemyDescription; set => EnemyDescription = value; }
    public float EnemySpeed1 { get => EnemySpeed; set => EnemySpeed = value; }
    public float EnemyHealth1 { get => EnemyHealth; set => EnemyHealth = value; }
    public float EnemyDamage1 { get => EnemyDamage; set => EnemyDamage = value; }

    public void Attacked(int damage)
    {
        EnemyHealth1 -= damage;

        Debug.Log(EnemyName + " has been hit! Health = " + EnemyHealth);
    }
}
