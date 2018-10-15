using UnityEngine;
namespace Shooter.Classic{
	public class Listener : MonoBehaviour {

		// Update is called once per frame
		public static Listener GM;
		[Header("Simulation settings")]
		public float topBound = 16.5f;
		public float bottomBound = -13.5f;
		public float leftBound = -23.5f;
		public float rightBound = 23.5f;
		[Header("Enemy settings")]
		public GameObject enemyShipPrefab;
		public float enemySpeed = 1f;
		[Header("Spawn settings")]
		public int enemyShipCount = 1;
		public int enemyShipIncrement = 1;
		int count;

		void Awake(){
			if(GM == null){
				GM = this;
			}else if(GM != this){
				Destroy(GM);
			} 
		}
		void Start(){
			AddShips(enemyShipIncrement);
		}

		void Update () {
			if(Input.GetKeyDown("space")){
				AddShips(enemyShipIncrement);
			}
		}

		void AddShips(int amount){
			for(int i=0 ; i < amount ; i++){
				float xVal = Random.Range(leftBound, rightBound);
				float zVal = Random.Range(0f, 10f);
				Vector3 pos = new Vector3(xVal, 0f, zVal + topBound);
				Quaternion rot = Quaternion.Euler(0f, 180f, 0f);
				var obj = Instantiate(enemyShipPrefab, pos, rot) as GameObject;
			}
			count += amount;
			Debug.Log(count);
		}
	}
}