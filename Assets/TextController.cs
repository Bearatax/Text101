using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Test comment
public class TextController : MonoBehaviour {

	public Text text;
	private enum States{office, cellphone, serverRoom_01, door_01, fixServerRoom, death_01, toolBox, door_02, death_02, toilets, death_03, serverRoom_02, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		//text.text = "Welcome to another installment of Goosebumps - LRMG edition. \n\n" + "Press 'Space' to star your adventure.";
		myState = States.office;
	}

	// Update is called once per frame
	void Update ()
	{
		if (myState == States.office) {
			state_office();
		}else if (myState == States.cellphone) {
			state_cellphone();
		}
		else if (myState == States.serverRoom_01) {
			state_serverRoom_01();
		}
		else if (myState == States.door_01) {
			state_door_01();
		}
	}

	void state_office ()
	{
		text.text = "You are sitting alone, friday night at the offices' of LRMG. " +
						"A storm starts to brew in the distance, creeping ever so closely. " +
						"The wind starts to howl a sad tone of a grieving mother, " + 
						"rain pouring down as if the very earth is melting and " +
						"the thunder is as loud as Thor beating his anvil." + 
						" Suddenly loadshedding!\n\n" + "Darkness is starting the overflow the office with only the laptop screen savers illuminating the office. " + 
						"You realize that the generators are not starting, someone or something might have turned them off...\n\n" +
						"Press C to check your Cellphone, press S to go to the Server room or press D to check the door.";
		if(Input.GetKeyDown (KeyCode.C)){			
			myState = States.cellphone;
		}
		else if(Input.GetKeyDown (KeyCode.S)){			
			myState = States.serverRoom_01;
		}
		else if(Input.GetKeyDown (KeyCode.D)){			
			myState = States.door_01;
		}


	}

	void state_cellphone ()
	{
		text.text = "Oh no, battery is dead, going to look back at the office\n\n" + "Press R to return to the Office.";
		if(Input.GetKeyDown (KeyCode.R)){			
			myState = States.office;
		}
	}

	void state_serverRoom_01 ()
	{
		text.text = "Server Room 01";
		if(Input.GetKeyDown (KeyCode.R)){			
			myState = States.office;
		}
	}

	void state_door_01 ()
	{
		text.text = "Door 01";
		if(Input.GetKeyDown (KeyCode.R)){			
			myState = States.office;
		}
	}

}
