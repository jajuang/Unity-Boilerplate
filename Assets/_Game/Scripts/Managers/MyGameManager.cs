using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Enums for easy-to-rename buttton names
public enum ButtonControlNames
{
	Start,
	UseAction,
	UseItem,
	Interact
}

public enum GameMode
{
	NormalPlay,
	StartMenu,
	ClosedStartMenuBuffer, // HACK: to make sure we don't start a convo with a close-by npc on start menu "Continue" click
	CombineMode
}

public class MyGameManager : MonoBehaviour
{
	#region variables
	public static MyGameManager _instance;
	public RuntimePlatform UserPlatform;

	public Dictionary<ButtonControlNames, KeyCode> ButtonControls_Controller;
	public Dictionary<ButtonControlNames, KeyCode> ButtonControls_Keyboard;
	
	public GameMode GameMode = GameMode.NormalPlay;
	#endregion


	void Awake()
	{
		_instance = this;
		UserPlatform = Application.platform;

		ButtonControls_Keyboard = new Dictionary<ButtonControlNames, KeyCode>();
		ButtonControls_Keyboard[ButtonControlNames.Start] = KeyCode.Escape;
		ButtonControls_Keyboard[ButtonControlNames.UseAction] = KeyCode.X;
		ButtonControls_Keyboard[ButtonControlNames.UseItem] = KeyCode.Z;
		ButtonControls_Keyboard[ButtonControlNames.Interact] = KeyCode.Space;
		//ButtonControls_Keyboard["LeftBumper"] = KeyCode.L;
		//ButtonControls_Keyboard["RightBumper"] = KeyCode.K;

		ButtonControls_Controller = new Dictionary<ButtonControlNames, KeyCode>();
		SetDefaultControllerValuesBasedOffOS(UserPlatform);
	}

	#region Controller and Keyboard Controls
	
	public void SetDefaultControllerValuesBasedOffOS(RuntimePlatform userOS)
	{
		if (userOS == RuntimePlatform.LinuxPlayer)
		{
			// TODO
		}
		else if (userOS == RuntimePlatform.OSXPlayer)
		{
			// TODO
		}
		else // Windows and everything else
		{
			ButtonControls_Controller[ButtonControlNames.Start] = KeyCode.Joystick1Button7; // Start Button
			ButtonControls_Controller[ButtonControlNames.UseAction] = KeyCode.Joystick1Button1; // B Button
			ButtonControls_Controller[ButtonControlNames.UseItem] = KeyCode.Joystick1Button2; // X Button
			ButtonControls_Controller[ButtonControlNames.Interact] = KeyCode.Joystick1Button0; // A Button
			//ButtonControls_Controller["LeftBumper"] = KeyCode.Joystick1Button4; // Left Bumper
			//ButtonControls_Controller["RigthBumper"] = KeyCode.Joystick1Button5; // Right Bumper
		}
	}

	#endregion

	public void UpdateButtonControl(bool isController, ButtonControlNames btnName)
	{
		// TODO
	}


}

