using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed;
	private Vector3 moveDirection = Vector3.zero;
	public Transform head;
//	public  AudioSource head1;
//	public bool ok;

	void FixedUpdate()
	{

		if (head.transform.eulerAngles.x <= 30f || head.transform.eulerAngles.x >= 80f) {
			CharacterController controller = GetComponent<CharacterController> ();
			moveDirection = new Vector3 (head.transform.forward.x, 0, head.transform.forward.z);
			moveDirection *= speed;
			controller.Move (moveDirection * Time.deltaTime);
			Debug.Log("I should move");

//			if (!(head1.GetComponent<AudioSource> ().isPlaying)) {
//				ok=head1.GetComponent<AudioSource> ().isPlaying;
//				head1.GetComponent<AudioSource> ().Play ();
//			}
		}

		//else
			//head1.GetComponent<AudioSource>().Pause();

		//CharacterController controller = GetComponent<CharacterController>();
		//Vector3 direction = new Vector3 (head.transform.forward.x, 0, head.transform.forward.z).normalized * speed * Time.deltaTime;
		//Quaternion rotation = Quaternion.Euler (new Vector3 (0, -transform.rotation.eulerAngles.y, 0));
		//transform.Translate (rotation * direction);
	}
}
