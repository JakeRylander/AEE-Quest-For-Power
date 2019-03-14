using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Scrolling : MonoBehaviour {

	[SerializeField] 
	public Vector2 speed = new Vector2(2, 2);


	[SerializeField] 
	public Vector2 direction = new Vector2(-1, 0);
	[SerializeField] 
	public Vector2 direction2 = new Vector2(1, 0);

	[SerializeField] 
	public bool isLinkedToCamera = false;

  
   void Start()
    {

    }

  void Update()
  {
		if (StageControl.instance.current_event == 2){
			float moveHorizontal = Input.GetAxis("Horizontal");
			if (moveHorizontal > 0) {
				Vector3 movement = new Vector3 (
					                      speed.x * direction.x,
					                      speed.y * direction.y,
					                      0);

				movement *= Time.deltaTime;
				transform.Translate (movement);

				// Move the camera
				if (isLinkedToCamera) {
					Camera.main.transform.Translate (movement);
				}
			} 
			else if (moveHorizontal < 0) {
				Vector3 movement = new Vector3 (
					speed.x * direction2.x,
					speed.y * direction2.y,
					0);

				movement *= Time.deltaTime;
				transform.Translate (movement);

				// Move the camera
				if (isLinkedToCamera) {
					Camera.main.transform.Translate (movement);
				}
			}
		}
    }
}
