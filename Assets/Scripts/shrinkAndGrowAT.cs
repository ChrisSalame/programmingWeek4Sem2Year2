using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.SocialPlatforms;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {


	public class shrinkAndGrowAT : ActionTask {

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise

        Vector3 baseSize = new Vector3(2f, 2f, 2f);
        Vector3 smallSize = new Vector3(0.5f, 0.5f, 0.5f);

        protected override string OnInit() {


            agent.transform.localScale = Vector3.Lerp(baseSize,smallSize, 8);
            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {


            //agent.transform.localScale = new Vector3.Lerp(baseSize, smallSize, 2);
            
			EndAction(true);
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