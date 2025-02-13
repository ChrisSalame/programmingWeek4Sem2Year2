using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class randSwimAT : ActionTask {

        public float searchRadius;
        private NavMeshAgent navAgent;

        public BBParameter<float> energy;
        public BBParameter<float> energyUsage;

        Vector3 finalDestination;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {


            navAgent = agent.GetComponent<NavMeshAgent>();
            Blackboard agentBlackboard = agent.GetComponent<Blackboard>();

            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {   

            Vector3 swimTarget = Random.insideUnitSphere * searchRadius;
            swimTarget += agent.transform.position;

            NavMeshHit hit;

            NavMesh.SamplePosition(swimTarget, out hit, searchRadius, 1);
            finalDestination = hit.position;

            navAgent.SetDestination(hit.position);
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

            energy.value -= energyUsage.value * Time.deltaTime;

            if (Vector3.Distance(agent.transform.position, finalDestination) < 1f)
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