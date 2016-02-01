using UnityEngine;
using System.Collections;

public class Actor : MonoBehaviour
{
    [SerializeField] public Vector3 Pos;
    [SerializeField] public float Health, Damage;
    [SerializeField] public string Name, Output;
    public void Update()
    {
        this.Move();
    }

    public virtual void Move()
    {
        Output = "Default Move";
        print(Output);
    }
}