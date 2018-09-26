using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{

	private int hp = 100;
	private int mp = 53;
	private int power = 25;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}

	public void Magic(){
		//Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);

		this.mp -= 5;

		if (this.mp < 0) {
			Debug.Log ("MPが足りないため魔法攻撃が使えない。");
		} else {
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
		}
	}

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int[] array = {0, 11, 22, 33, 44};

		for(int i = 0; i < 5; i++){
			//array[i];
			Debug.Log (array[i]);
		}

		for(int i = 4; i >= 0; i--){
			//array[i];
			Debug.Log (array[i]);
		}
			
		Boss lastboss = new Boss ();

		lastboss.Attack ();
		lastboss.Defence (3);
		lastboss.Magic ();

		for(int i = 0; i < 10; i++){
			lastboss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){



		}
	}
}
