using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movementController : MonoBehaviour
{
	float speed = 4;
	float rotSpeed = 100;
	float rot = 0f;
	float gravity = 8;


	Vector3 moveDir = Vector3.zero;


	CharacterController controller;
	Animator anim;




	// Start is called before the first frame update
	void Start()
	{


		controller = GetComponent<CharacterController>();
		anim = GetComponent<Animator>();
	}


	// Update is called once per frame
}