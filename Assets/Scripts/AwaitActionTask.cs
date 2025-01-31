using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions{

	public class AwaitActionTask : ActionTask{
		public float maxWaitTime;
		public float minWaitTime;

		private float timeRemaining;

		protected override string OnInit(){
			//float maxWaitTime = Random.Range(0f,10f);
            return null;
		}


		protected override void OnExecute(){

            //minWaitTime = UnityEngine.Random.Range(0f,2f);
            //maxWaitTime = UnityEngine.Random.Range(2f, 10f);
            //Debug.Log("minWaitTime");
            //Debug.Log("maxWaitTime");

            timeRemaining = UnityEngine.Random.Range(minWaitTime, maxWaitTime);
			Debug.Log("timeRemaining");

        }


		protected override void OnUpdate(){

            //Wait a random amount of time between two values
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                EndAction(true);
            }


        }

        //Called when the task is disabled.
        protected override void OnStop(){
			
		}

		//Called when the task is paused.
		protected override void OnPause(){
			
		}
	}
}