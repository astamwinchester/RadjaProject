using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private FirstPersonAIO firstPersonAIO;

	public void EnableCameraMovement (bool enable)
	{
		if ( firstPersonAIO == null )
			firstPersonAIO = GetComponent<FirstPersonAIO>();
		firstPersonAIO.enableCameraMovement = enable;
	}

	public void EnableWalkMovement (bool enable)
	{
		if ( firstPersonAIO == null )
			firstPersonAIO = GetComponent<FirstPersonAIO>();
		firstPersonAIO.playerCanMove = enable;
	}
}
