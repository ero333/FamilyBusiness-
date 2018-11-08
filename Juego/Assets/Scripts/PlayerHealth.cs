﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class PlayerHealth : MonoBehaviour {
	public static bool dead=false;
    private string sceneName;
    float originalWidth = 1920.0f; //turn these to floats to fix placement issue
	float originalHeight = 1080.0f;
	Vector3 scale;
	public GUIStyle text;
	public Texture2D bg;
	public Sprite deadSpr;
    private bool flagdead = false;
    public GameObject elevatorPosition;
    Vector3 initialPosition;
    

	void awake()
	{
        
    }

	// Use this for initialization
	void Start () {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        
        
        if (sceneName == "Level10")
        {
            initialPosition = this.gameObject.transform.position;

            if (GameManager.check10 == true)
            {
                this.gameObject.transform.position = elevatorPosition.transform.position;
                Destroy(GameObject.Find("enemigos Piso 0"));
            }

            else if (GameManager.check10 == false)
            {
                this.gameObject.transform.position = initialPosition;

            }
        }
        

    }
	
	// Update is called once per frame
	void Update () {

        if (dead == true) {
            killPlayer();
            GameManager.playerPosition = this.transform.position;
            
            if (sceneName == "Level1" && flagdead == false)
            {
                GameManager.muertes1 += 1;
                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 1 }   }
                );
                                          
                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "tiempo", GameManager.tiempoNivel1 }   }
                );
                
                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
                );
                
                
                flagdead = true;

            }

            else if (sceneName == "Level2" && flagdead == false)
            {
                GameManager.muertes2 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 2 }   }
                );
                

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "tiempo", GameManager.tiempoNivel2 }   }
               );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
               );

                flagdead = true;
            }

            else if (sceneName == "Level3" && flagdead == false)
            {
                GameManager.muertes3 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 3 }   }
                );
                

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "tiempo", GameManager.tiempoNivel3 }   }
               );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
               );

                flagdead = true;
            }
            else if (sceneName == "Level4" && flagdead == false)
            {
                GameManager.muertes4 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 4 }   }
                );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "tiempo", GameManager.tiempoNivel4 }   }
               );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
               );

                flagdead = true;

            }
            else if (sceneName == "Level5" && flagdead == false)
            {
                GameManager.muertes5 += 5;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 5 }   }
                );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "tiempo", GameManager.tiempoNivel5 }   }
               );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
               );

                flagdead = true;

            }
            else if (sceneName == "Level6" && flagdead == false)
            {
                GameManager.muertes6 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 6 }   }
                );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "tiempo", GameManager.tiempoNivel6 }   }
               );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
               );

                flagdead = true;

            }
            else if (sceneName == "Level7" && flagdead == false)
            {
                GameManager.muertes7 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 7 }   }
                );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "tiempo", GameManager.tiempoNivel7 }   }
               );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
               );

                flagdead = true;

            }
            else if (sceneName == "Level8" && flagdead == false)
            {
                GameManager.muertes8 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 8 }   }
                );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "tiempo", GameManager.tiempoNivel8 }   }
               );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
               );

                flagdead = true;

            }
            else if (sceneName == "Level9" && flagdead == false)
            {
                GameManager.muertes9 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 9 }   }
                );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "tiempo", GameManager.tiempoNivel9 }   }
               );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
               );

                flagdead = true;

            }
            else if (sceneName == "Level10" && flagdead == false)
            {
                GameManager.muertes10 += 1;

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "nivel", 10}   }
                );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "tiempo", GameManager.tiempoNivel10 }   }
               );

                Analytics.CustomEvent("Morir", new Dictionary<string, object>
                {  { "CoordenadasXYZ", GameManager.playerPosition }   }
               );

                flagdead = true;               

            }



            if (Input.GetKeyDown (KeyCode.R)) {

                VideoPlay.showoOne = false; // Comentar para mostrar una vez el cutscene

                if (sceneName == "Level1")
                {

                    if (Time.timeSinceLevelLoad > 0)
                    {
                        GameManager.tiempoTotalNivel1 += Time.timeSinceLevelLoad;
                    }
                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "nivel", 1 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "vez", GameManager.muertes1 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "tiempo", GameManager.tiempoNivel1 }   }
                    );                    

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "muertes", ContarMuertos.contMuertos }   }
                        );

                }
            else if (sceneName == "Level2")
            {

                    if (Time.timeSinceLevelLoad > 0)
                    {
                        GameManager.tiempoTotalNivel2 += Time.timeSinceLevelLoad;
                    }

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 2 }   }
                );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "vez", GameManager.muertes2 }   }
                        );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "tiempo", GameManager.tiempoNivel2 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "muertes", ContadorEnemigos.enemigosLeft }   }
                    );
                }
            else if (sceneName == "Level3")
            {

                    if (Time.timeSinceLevelLoad > 0)
                    {
                        GameManager.tiempoTotalNivel3 += Time.timeSinceLevelLoad;
                    }

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 3 }   }
                );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "vez", GameManager.muertes3 }   }
                        );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "tiempo", GameManager.tiempoNivel3 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "muertes", ContadorEnemigos.enemigosLeft }   }
                    );

                }
            else if (sceneName == "Level4")
            {

                    if (Time.timeSinceLevelLoad > 0)
                    {
                        GameManager.tiempoTotalNivel4 += Time.timeSinceLevelLoad;
                    }

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 4 }   }
                );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "vez", GameManager.muertes4 }   }
                        );


                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "tiempo", GameManager.tiempoNivel4 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "muertes", ContadorEnemigos.enemigosLeft }   }
                    );

                }
            else if (sceneName == "Level5")
            {

                    if (Time.timeSinceLevelLoad > 0)
                    {
                        GameManager.tiempoTotalNivel5 += Time.timeSinceLevelLoad;
                    }

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 5 }   }
                );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "vez", GameManager.muertes5 }   }
                        );


                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "tiempo", GameManager.tiempoNivel5 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "muertes", ContadorEnemigos.enemigosLeft }   }
                    );

                }
            else if (sceneName == "Level6")
            {

                    if (Time.timeSinceLevelLoad > 0)
                    {
                        GameManager.tiempoTotalNivel6 += Time.timeSinceLevelLoad;
                    }

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 6 }   }
                );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "vez", GameManager.muertes6 }   }
                        );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "tiempo", GameManager.tiempoNivel6 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "muertes", ContadorEnemigos.enemigosLeft }   }
                    );

                }
            else if (sceneName == "Level7")
            {

                    if (Time.timeSinceLevelLoad > 0)
                    {
                        GameManager.tiempoTotalNivel7 += Time.timeSinceLevelLoad;
                    }

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 7 }   }
                );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "vez", GameManager.muertes7 }   }
                        );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "tiempo", GameManager.tiempoNivel7 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "muertes", ContadorEnemigos.enemigosLeft }   }
                    );

                }
            else if (sceneName == "Level8")
            {

                    if (Time.timeSinceLevelLoad > 0)
                    {
                        GameManager.tiempoTotalNivel8 += Time.timeSinceLevelLoad;
                    }

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 8 }   }
                );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "vez", GameManager.muertes8 }   }
                        );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "tiempo", GameManager.tiempoNivel8 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "muertes", ContadorEnemigos.enemigosLeft }   }
                    );

                }
            else if (sceneName == "Level9")
            {
                    if (Time.timeSinceLevelLoad > 0)
                    {
                        GameManager.tiempoTotalNivel9 += Time.timeSinceLevelLoad;
                    }


                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 9 }   }
                );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "vez", GameManager.muertes9 }   }
                        );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "tiempo", GameManager.tiempoNivel9 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "muertes", ContadorEnemigos.enemigosLeft }   }
                    );

                }
            else if (sceneName == "Level10")
            {
                    if (Time.timeSinceLevelLoad > 0)
                    {
                        GameManager.tiempoTotalNivel10 += Time.timeSinceLevelLoad;
                    }

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "nivel", 10}   }
                );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                {  { "vez", GameManager.muertes10 }   }
                        );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "tiempo", GameManager.tiempoNivel10 }   }
                    );

                    Analytics.CustomEvent("ReiniciarNivel", new Dictionary<string, object>
                    {  { "muertes", ContadorEnemigos.enemigosLeft }   }
                    );

                }
                Debug.Log("------------------------------------------------- Revive");
                revivePlayer();
                SceneManager.LoadScene (SceneManager.GetActiveScene().name);//remember to mention new scene manager using thing                
                

            }
		}
	}
    
    void killPlayer()
	{
		if (this.GetComponent<PlayerAnimate> ().enabled == true) {
			PlayerAnimate pa = this.GetComponent<PlayerAnimate> ();
			PlayerMovement pm = this.GetComponent<PlayerMovement> ();
			RotateToCursor rot = this.GetComponent<RotateToCursor> ();
			WeaponAttack wa = this.GetComponent<WeaponAttack> ();
			legDir ld = this.GetComponentInChildren<legDir> ();
			wa.dropWeapon ();
			pa.legs.sprite = null;
			pa.legs.enabled = false;
			ld.enabled = false;

			pa.torso.sprite = deadSpr;
			pa.enabled = false;

			rot.enabled = false;
			wa.enabled = false;

			pm.enabled = false;
			CircleCollider2D col = this.GetComponent<CircleCollider2D> ();
			col.enabled = false;            
        }

       
    }

	void revivePlayer(){

        dead = false;

        Debug.Log("PlayerHealth - revivePlayer");

		PlayerAnimate pa = this.GetComponent<PlayerAnimate> ();
		PlayerMovement pm = this.GetComponent<PlayerMovement> ();
		RotateToCursor rot = this.GetComponent<RotateToCursor> ();
		WeaponAttack wa = this.GetComponent<WeaponAttack> ();
        dead = false;
        legDir ld = this.GetComponentInChildren<legDir> ();
		wa.dropWeapon ();
		pa.legs.enabled = true;
		ld.enabled = true;
		pa.enabled = true;
		rot.enabled = true;
		wa.enabled = true;
		pm.enabled = true;
		CircleCollider2D col = this.GetComponent<CircleCollider2D> ();
		col.enabled = true;
       
    }

	void OnGUI()
	{
		GUI.depth = 0;
		scale.x = Screen.width/originalWidth;
		scale.y = Screen.height/originalHeight;
		scale.z =1;
		var svMat = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero,Quaternion.identity,scale);

		if (dead == true) {
			Rect posForRestart = new Rect (100,originalHeight-200,500,150);
			GUI.DrawTexture (posForRestart,bg);
			GUI.Box (posForRestart,"Press 'R' to restart",text);
		}

		GUI.matrix = svMat;
	}
}
