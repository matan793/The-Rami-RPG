using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Movment;
using System;
using RPG.Combat;

namespace RPG.Control
{
    public class PlayerController : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if(CombatControl()) return;
            if(MovmentControl()) return;
        }

        private bool CombatControl()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] rays = Physics.RaycastAll(ray);
            foreach (var item in rays)
            {
                if(item.transform.GetComponent<CombatTarget>() != null)
                {
                    if (Input.GetMouseButton(0))
                    {
                        GetComponent<Fighter>().Attack(item.transform.GetComponent<CombatTarget>());
                        
                    }
                    return true;
                }
            }
            return false;
        }

        private bool MovmentControl()
        {


            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            bool hit = Physics.Raycast(ray, out raycastHit);
            if (hit)
            {
                if (Input.GetMouseButton(0))
                {
                    GetComponent<Mover>().StartMoving(raycastHit.point);
                }
                return true;
            }
            return false;

        }
    }
}
