using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class DebugAT : ActionTask {

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {

			Debug.Log("Debug is Initialized");

			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {


			Debug.Log("Debug is Executing");
			
			//EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate()
		{
			Debug.Log("Debug is Updating.");
			//agent.transform.position += agent.transform.forward * 3f * Time.deltaTime;
			//Rigidbody rt = agent.GetComponent<Rigidbody>();
			//agent.gameObject.SetActive(true);
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}