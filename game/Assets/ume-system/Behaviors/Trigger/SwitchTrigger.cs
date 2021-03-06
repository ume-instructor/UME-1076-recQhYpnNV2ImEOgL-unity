
using UnityEngine;
using System.Collections;

namespace UME
{
    [AddComponentMenu("UME/Triggers/SwitchTrigger")]
    public class SwitchTrigger : BaseTrigger {

		public GameObject targetObject;
		public bool onOff = true;
		// Use this for initialization
		public override void Initialize () {
			if (targetObject != null){
				targetObject.SetActive(!onOff);
			}
		}
		public override void Activate (Collider2D other)
		{
			if (targetObject != null){
				targetObject.SetActive(onOff);
			}

		}
	}

}