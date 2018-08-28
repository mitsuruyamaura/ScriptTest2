using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss{
    private int hp = 100;   //  HP
    private int power = 25; //  攻撃力
    private int mp = 53;    //  MP

    //  攻撃用の関数
    public void Attack(){
        Debug.Log( this.power + "のダメージを与えた。");
    }

    //　防御用の関数
    public void Defence( int damage ) {
        Debug.Log(damage + "のダメージを受けた。");
        //  残りHPを減らす
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic( int mana ){

        
            //  MPが５以上だった場合の処理
            if (mp >= 5) {

                //  残りMPを減らす
                this.mp -= mana;

                Debug.Log("魔法攻撃をした。残りMPは" + this.mp);

            } else {    //  それ以外の場合
                Debug.Log("MPが足りないため、魔法が使えない。");
            }

        //return mp;
    }
}

public class ScriptTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //  配列を初期化する
        int[] array = { 25, 40, 800, 27, 75 };

        //  配列の要素を順番に表示する
        for(int i = 0; i < array.Length; i++){
            Debug.Log(array[i]);
        }

        //  配列の要素を逆の順番で表示する
        for(int j= 4; j > -1; j--){
            Debug.Log(array[j]);
        }


        //  Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //  攻撃用の関数を呼び出す
        lastboss.Attack();

        //　防御用の関数を呼び出す
        lastboss.Defence(3);

        //  魔法攻撃用の関数を呼び出す
        for (int i = 0; i < 11; i++){
            lastboss.Magic(5);
        }
        
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
