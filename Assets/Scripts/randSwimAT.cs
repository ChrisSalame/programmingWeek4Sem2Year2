using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class randSwimAT : ActionTask {

        public float searchRadius;
        private NavMeshAgent navAgent;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {


            navAgent = agent.GetComponent<NavMeshAgent>();

            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

            Vector3 swimTarget = Random.insideUnitSphere * searchRadius + agent.transform.position;
            NavMeshHit navMeshHit;
            if (!NavMesh.SamplePosition (swimTarget, out navMeshHit, searchRadius, NavMesh.AllAreas))
            {
                return;
            }

            navAgent.SetDestination(navMeshHit.position);
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

            if (navAgent.pathPending && navAgent.remainingDistance <= navAgent.stoppingDistance)
            {
                EndAction(true);

            }

        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}