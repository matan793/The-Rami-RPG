using RPG.Movment;
using RPG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour, RPG.Core.IAction
    {
        public float range = 2f;
        Transform target;
        private void Update()
        {
            if (target != null && !IsInRange())
                GetComponent<Mover>().MoveTo(target.position);
            else
                GetComponent<Mover>().StopMovment();
        }
        public bool IsInRange()
        {
            return Vector3.Distance(transform.position, target.position) < range;
        }
        public void Attack(CombatTarget target)
        {
            //GetComponent<Core.ActionManeger>().StartAction(this);
            this.target = target.transform;
            //print("attacking");
        }
        public void Cancel()
        {
           target = null;
        }
    }
}

