using UnityEngine;
namespace Shooter.Classic{
	public class Movement : MonoBehaviour {
		void Update () {
			Vector3 pos = transform.position;
			pos += transform.forward * Listener.GM.enemySpeed * Time.deltaTime * -1;
			if(pos.z < Listener.GM.bottomBound){
				pos.z = Listener.GM.topBound;
			}
			transform.position = pos;
		}
	}
}