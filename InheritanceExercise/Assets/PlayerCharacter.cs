using UnityEngine;
using System.Collections;


    public class PlayerCharacter : Actor
    {
        [SerializeField] private int[] Inventory;
        public override void Move()
        {
            Output = "Player Move";
        print(Output);
    }
    }
