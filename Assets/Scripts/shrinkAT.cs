using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {


	public class shrinkAT : ActionTask {

        Vector3 baseSize = new Vector3(6f, 6f, 6f);
        Vector3 bigSize = new Vector3(10f, 10f, 10f);

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			Debug.Log("PufferFish Shrink");
            agent.transform.localScale = Vector3.Lerp(agent.transform.localScale, baseSize, 1);
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}