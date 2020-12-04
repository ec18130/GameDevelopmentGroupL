/*
ElevatorButton.cs - wirted by ThunderWire Games * Script for Elevator Buttons
*/

using UnityEngine;
using System.Collections;

public class ElevatorButton : MonoBehaviour {
	
	public GameObject m_ElevatorController;
    public Animator[] lift;

    [HideInInspector]
	public bool ElevatorMoving;
	
	public void SendCall (string Call) {
		ElevatorController Elevator = m_ElevatorController.GetComponent<ElevatorController>();
		ElevatorMoving = Elevator.ElevatorMoving;
		if(Call == "ElevatorUp" && !ElevatorMoving)
		{
			Elevator.ElevatorGO("ElevatorUp");
            for (int i = 0; i < lift.Length; i++)
            {
                lift[i].SetBool("Opened", false);
            }
        }
		
		if(Call == "ElevatorDown" && !ElevatorMoving)
		{
			Elevator.ElevatorGO("ElevatorDown");
            for (int i = 0; i < lift.Length; i++)
            {
                lift[i].SetBool("Opened", false);
            }
        }
	}
}
