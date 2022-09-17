using RPG.Movment;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        public float range = 2f;
        Transform target;
        private void Update()
        {
            bool Isrange = Vector3.Distance(transform.position, target.position) < range;
            if (target != null && !Isrange)
                GetComponent<Mover>().MoveTo(target.position);
            else
                GetComponent<Mover>().StopMovment();
        }
        public void Attack(CombatTarget target)
        {
            this.target = target.transform;
            print("attacking");
        }
    }
}

