using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

namespace RPG.Movment
{
    public class Mover : MonoBehaviour
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
        public void MoveTo(Vector3 dest)
        {
            GetComponent<NavMeshAgent>().destination = dest;
            GetComponent<NavMeshAgent>().isStopped = false;
        }
    }
}
