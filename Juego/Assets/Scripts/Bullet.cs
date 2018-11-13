﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public Vector3 direction;
    public string creator;
	EnemyAttacked attacked;
	HeavyAttacked ha;
    public string arma;
    public string asesino;
	public GameObject bloodImpact,wallImpact;
    
	// Use this for initialization
	float timer = 10.0f;


	void Start () {
	    
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (direction*17*Time.deltaTime);

		timer -= Time.deltaTime;
		if(timer<=0)
		{
			Destroy (this.gameObject);
		}
	}

	public void setVals(Vector3 dir, string name)
	{
		direction = dir;
		creator = name;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy") {
			attacked = col.gameObject.GetComponent<EnemyAttacked> ();
            //attacked.killBullet (); // Llama a la funcion para matar con arma

            // EL SIGUIENTE CODIGO ES PARA QUE MIRTHA TENGA MAS VIDA
            
            if (GameManager.lifeBoss > 0 && col.gameObject.name == "Mirtha")
            {
                GameManager.lifeBoss -= 1;
            }
            else
            {
                attacked.killBullet(this);
            } 
            
            // AQUI TERMINA EL CODIGO PARA MIRTHA

            Instantiate (bloodImpact, this.transform.position, this.transform.rotation);
			Destroy (this.gameObject);
		} else if (col.gameObject.tag == "Enemy" && creator == "Enemy") {

		} else if (col.gameObject.tag == "Heavy") {
			ha = col.gameObject.GetComponent<HeavyAttacked> ();
			ha.hitByBullet ();
			Instantiate (bloodImpact, this.transform.position, this.transform.rotation);
			Destroy (this.gameObject);
		} else if (col.gameObject.tag == "Player") {
			Instantiate (bloodImpact, this.transform.position, this.transform.rotation);
			Debug.Log("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Bullet");

            if(!PlayerHealth.dead)
            {
                PlayerHealth.dead = true;//new for 10
                Debug.Log("me mato con el arma " + arma);
                Debug.Log("Insertar evento Morir aqui");
                // Morir
                /*
                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 1 } 
                  { "tiempo", GameManager.tiempoNivel1 }   }
                );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
                );

    */
            }

            Destroy (this.gameObject);
		} else if (col.gameObject.tag != "Enemy" && col.gameObject.tag != "Player" && col.gameObject.tag != "Dog" && col.gameObject.tag!="Heavy") {
			//Debug.Log ("hit");
			Instantiate (wallImpact, this.transform.position, this.transform.rotation);
			Destroy (this.gameObject);
		} else if (col.gameObject.tag == "Dog") {
			Instantiate (bloodImpact, this.transform.position, this.transform.rotation);
			col.gameObject.GetComponent<DogHealth> ().killDog ();
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.GetComponent<EnemyAttacked> () == true) {
			other.gameObject.GetComponent<EnemyAttacked> ().execute ();
		}
	}
}
