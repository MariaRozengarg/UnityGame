using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactive : MonoBehaviour {

    public GameObject canvasE;
    public GameObject canvasD;
    public GameObject textCourpse;
    public GameObject textDeath;
    public GameObject textChain;
    public GameObject textKey;
    public GameObject textChainOpen;
    public GameObject textGameOver;
    public GameObject imageBack;

    public GameObject key;
    public GameObject chainTrigger;
    private GameObject trigger;


    private bool isPicked = false;

    
    public void OnTriggerExit(Collider other)
    {
        canvasE.SetActive(false);
    }


    public void OnTriggerStay(Collider other)
    {
        //canvasE.SetActive(true);
        //canvasE.SetActive(false);

        switch(other.transform.tag)
        {
        	case "Object_Corpse":
	        	//Debug.Log("ДратутиТруп");

        		canvasE.SetActive(true);

        		if (Input.GetKeyDown(KeyCode.E))
		        {
		            imageBack.SetActive(true);
		            textCourpse.SetActive(true);
		        	//text = GameObject.Find("TextCourpse");
		            //text.SetActive(true);
		        }	        	
		        break;

        	case "Object_Death":
        		//Debug.Log("ДратутиСмерть");

        		canvasE.SetActive(true);

        		if (Input.GetKeyDown(KeyCode.E))
		        {
		            imageBack.SetActive(true);
		            textDeath.SetActive(true);
		            //canvasD.SetActive(true);
		        }	        	
		        break;

        	// case "Object_Coffin":
        	// 	//Debug.Log("ДратутиГроб");

        	// 	canvasE.SetActive(true);

        	// 	if (Input.GetKeyDown(KeyCode.E))
		       //  {
		       //      //canvasD.SetActive(true);
		       //  }	        	
		       //  break;

        	case "Object_Key":
        		//Debug.Log("ДратутиКлюч");

        		canvasE.SetActive(true);

        		if (Input.GetKeyDown(KeyCode.E))
		        {
		            imageBack.SetActive(true);
		            textKey.SetActive(true);
		            isPicked = true;
		            key.SetActive(false);
        			canvasE.SetActive(false);

		        }	        	
		        break;

        	case "Object_Chain":
        		//Debug.Log("ДратутиЦепь");

        		canvasE.SetActive(true);

        		if (Input.GetKeyDown(KeyCode.E))
        		{
	        		if (isPicked == true)
			        {

			            imageBack.SetActive(true);
			            textChainOpen.SetActive(true);
			            chainTrigger.SetActive(true);
	             		canvasE.SetActive(false);
         				trigger = GameObject.Find("TriggerChain");
	      				trigger.SetActive(false);

			        }
			        else 
			        {
			        	imageBack.SetActive(true);
			        	textChain.SetActive(true);
			        }	   
			    }     	
		        break;

	        default:
	            //canvasE.SetActive(false);
	        	//Debug.Log("Вне зоны доступа");
	        	break;
        }

        // if (other.transform.tag == "Object_Corpse")
        // {
        //     canvasE.SetActive(true);

	       //  if (Input.GetKeyDown(KeyCode.E))
	       //  {
	       //      canvasD.SetActive(true);
	       //      //isPaused = true;

	       //   //   	if (Input.GetKeyDown(KeyCode.R))
	       //  	// {
	       //   //    	canvasD.SetActive(false);
	       //   //    	//isPaused = false;
	       //   //    }
        //    	 	// GameTime showText = text.GetComponent<GameTime>();
        //     	// showText.enabled = false;
	       //      //isPaused = true;
	       //      //isOutsideScreen = true;

	       //      // Cursor.lockState = CursorLockMode.None;
	       //      // Cursor.visible = true;
	       //      // isLocked = false;

	       //      // AudioSource[] srs = GetComponents<AudioSource>(); // отключение звуков машины 
	       //      // for (int i = 0; i <= 3; i++)
	       //      // {
	       //      //     srs[i].enabled = false;
	       //      // }
	       //  }

        //     //isFinished = true;

        //     // GameObject car = GameObject.Find("CarMain");
        //     // CarUserControl control = car.GetComponent<CarUserControl>();
        //     // control.enabled = false;

        //     // GameTime showText = text.GetComponent<GameTime>();
        //     // showText.enabled = false;
        // }

        // else if (other.transform.tag == "Object_Death")
        // {
        //     canvasE.SetActive(true);

	       //  if (Input.GetKeyDown(KeyCode.E))
	       //  {
	       //      canvasD.SetActive(true);
	       //  }
        // }
        // else if (other.transform.tag == "Object_Coffin")
        // {
        //     canvasE.SetActive(true);

	       //  if (Input.GetKeyDown(KeyCode.E))
	       //  {
	       //      canvasD.SetActive(true);
	       //  }
        // }
        // else if (other.transform.tag == "Object_Key")
        // {
        //     canvasE.SetActive(true);

	       //  if (Input.GetKeyDown(KeyCode.E))
	       //  {
	       //      canvasD.SetActive(true);
	       //  }
        // }
        // else if (other.transform.tag == "Object_Chain")
        // {
        //     canvasE.SetActive(true);

	       //  if (Input.GetKeyDown(KeyCode.E))
	       //  {
	       //      canvasD.SetActive(true);
	       //  }
        // }
        // else
        // {
        // 	canvasE.SetActive(false);
        // }

	    // if (Input.GetKeyDown(KeyCode.R))
    	// {
     //    	canvasD.SetActive(false);
     //    	//isPaused = false;
     //    }
    }


    void Update()
    {
    	if (Input.GetKeyDown(KeyCode.R))
    	{
        	//canvasD.SetActive(false);
        	//isPaused = false;

            imageBack.SetActive(false);
            textCourpse.SetActive(false);
            textDeath.SetActive(false);
            textChain.SetActive(false);
            textKey.SetActive(false);
            textChainOpen.SetActive(false);
            textGameOver.SetActive(false);
            //text.SetActive(false);
        }
    }


	// public void Pause(bool pause)
 //    {
 //        if (isPaused == false)
 //        {
 //            canvasPause.SetActive(true);

 //            isPaused = true;
 //            //isOutsideScreen = true;

 //            AudioSource[] srs = GetComponents<AudioSource>(); // отключение звуков машины 
 //            for (int i = 0; i <= 3; i++)
 //            {
 //                srs[i].enabled = false;
 //            }
 //        }

 //        if (isPaused == true)
 //        {
 //            timing = 0;
 //        }
 //        else if (isPaused == false)
 //        {
 //            timing = 1;
 //        }
 //    }
}
