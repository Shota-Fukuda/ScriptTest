using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100; // 体力
	private int power = 25; //攻撃力
	private int mp = 53; // 魔力

	// 攻撃用の関数
	public void Attack() {
		Debug.Log (this.power + "のダメージを与えた");
	}

	// 防御用の関数
	public void Defence(int damage) {
		Debug.Log (damage + "のダメージを受けた");
		// 残りhpを減らす
		this.hp -= damage;
	}

	public void Magic() {
		if (this.mp >= 5){
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。　残りMPは" + this.mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない");
		}
	}
}
public class Test : MonoBehaviour {
		/*
				// 「Hello」に続けて引数の文字列を表示する関数
				void HelloName(string name){
					Debug.Log ("Hello, " + name);



				// 第一引数と第二引数の値を足した値を返す関数
				int Add(int a, int b){
				// 第一引数と第二引数の値を足して、変数cに代入する
				int c = a + b;
				// 変数cを呼び出し元の関数に返す
				return c;
	}
		*/

	// Use this for initialization
	void Start () {
		/*
				コンソールにHeloo, Worldと表示
				Debug.Log("Hello, World");

				//変数の宣言
				int score;
				//変数の代入
				score = 150;
				//コンソールに変数の中身を表示
				Debug.Log(score);


				// 変数を初期化する
				int a = 3;
				int b = 4;
				// 変数aと変数bの合計値を変数cに代入する
				int c = a + b;
				// 変数cを表示する
				Debug.Log (c);


				int money = 100;

				if (money <= 50) {
					// moneyの値が50以下の場合の処理
					Debug.Log ("武器を売る");
				} else if (money >= 200) {
					// moneyが200未満だった場合の処理
					Debug.Log ("武器を買う");
				} else {
					// それ以外の処理
					Debug.Log ("ポーションを買う");
				}


				// numを1で初期化する
					int num = 1;
				// valに代入する値を条件によって変える(三項演算子)
				int val = (num == 1) ? -100 : 100;
				// valの値を表示
				Debug.Log(val);


				int a = 3;
				if (a == 3) {
					// 変数aが3の場合、変数bを5で初期化する
					int b = 5;
					// 変数bの値を表示する
					Debug.Log (b);
				}


				// sumを0で初期化する
				int sum = 0;
				// 10回処理を繰り返す
				for (int i = 0; i <= 10; i++) {
					// iの値をsumに足す
					sum += i;
				}
					Debug.Log (sum);


				// 配列を初期化する
				int [] points = {30, 20, 50, 10, 80, 15, 60, 100};

				// 配列の要素数のぶんだけ処理を繰り返す
				for (int i = 0; i < points.Length; i++) {
					// 配列の要素が50以上の場合
					if (points [i] >= 50) {
						// 配列の要素を表示する
						Debug.Log (points [i]);
					}
				}
	
				HelloName ("Unity");


				// Add関数に「3」と「6」の引数を繰り返し、返り値をnum変数に代入する
				int num = Add (3, 6);
				// numを表示する
				Debug.Log (num);

				// Bossクラスの変数を宣言してインスタンスを代入
				Boss lastboss = new Boss ();

				// 攻撃用の関数を呼び出す
				lastboss.Attack();
				// 防御用の関数を呼び出す
				lastboss.Defence(3);

		*/

				int[] array = new int[5];

				array [0] = 15;
				array [1] = 21;
				array [2] = 12;
				array [3] = 300;
				array [4] = 83;

				for (int i = 0; i < 5; i++) {
					Debug.Log (array [i]);
				}
				for (int j = 4; j >= 0; j--) {
					Debug.Log (array [j]);
				}
				Boss lastboss = new Boss ();
				for (int k = 0; k <= 10; k++) {
					lastboss.Magic ();
				}
		}
		
	
	
	// Update is called once per frame
	void Update () {
		
	}
}