using RPG.Combat;
using RPG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using RPG.Core;

namespace RPG.Movment
{
    public class Mover : MonoBehaviour, Core.IAction
    {
        public Transform target;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //if(Input.GetMouseButton(0))
            //{
            //    MoveTOCursore();

            //}

            UpdateAnimator();


        }
        private void UpdateAnimator()
        {
            Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
            Vector3 localvelocity = transform.InverseTransformDirection(velocity);
            float speed = localvelocity.z;
            GetComponent<Animator>().SetFloat("FSpeed", speed);

        }
        public void StopMovment()
        {
           
            GetComponent<NavMeshAgent>().isStopped = true;
        }
        public void StartMoving(Vector3 dest)
        {
            GetComponent<ActionManeger>().StartAction(this);
            GetComponent<Fighter>().Cancel();
            MoveTo(dest);
        }
        public void Cancel()
        {
            print("nigger");
        }
        public void MoveTo(Vector3 dest)
        {
            
            GetComponent<NavMeshAgent>().destination = dest;
            GetComponent<NavMeshAgent>().isStopped = false;
        }
    }
}
