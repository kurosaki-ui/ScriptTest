using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss 
{
	private int hp =100;	
	private int power = 25;
	private int mp = 53;
	public void Attack()
	{
		Debug.Log(this.power + "のダメージを与えた");
	}
	public void Defence(int damage)
	{
		Debug.Log(damage + "ダメージを受けた");
		this.hp -= damage;
	}
	public void MagicAttack()
	{
		if(this.mp >= 5)
		{
			this.mp = mp - 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
		}else
		{
			Debug.Log("MPが足りないため魔法が使えない。");				
		}
	}
}

public class Test : MonoBehaviour 
{
	int[] array = {10, 20, 30, 40, 50};

	int Add(int a, int b, int c)
	{
		int d = a + b + c;
		return d;
	}	
	// Use this for initialization
	void Start () 
	{
		int num = Add(3, 6, 5);
		Debug.Log(num);

		Boss midboss = new Boss();
		midboss.Attack();
		midboss.Defence(3);

		for(int i=0; i < 11; i++)
		{
			midboss.MagicAttack();
		}
		
		for(int i=0; i<array.Length; i++)
		{
			Debug.Log(array[i]);
		}

		for(int i = array.Length - 1; i >= 0; i--)
		{
			Debug.Log(array[i]);
		}
	}
		
	
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
