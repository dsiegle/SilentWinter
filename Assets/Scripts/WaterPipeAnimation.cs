﻿using UnityEngine;
using System.Collections;

public class WaterPipeAnimation : MonoBehaviour {
	
	public Sprite[] sprites;
	public float fps;
	private SpriteRenderer spriteRenderer;
	private TimeCalculationScript to;
	//private float yscale;
	
	// Use this for initialization
	void Start () {
		//Debug.Log ("AnimatePipeScript.Start() called");
		fps = 10;
		spriteRenderer = GetComponent<Renderer>() as SpriteRenderer;
		//to = TimeCalculationScript.tcs;
		to = GameObject.Find ("TimeObject").GetComponent<TimeCalculationScript> ();
		
		// CHEAT: The water top animation bit isn't visible and is scaled very small
		// in the y-direction at start.
		// I'm hoping to remove this once I get a blocking sprite in place.
		//transform.localScale = new Vector3(90,0,90);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("AnimateWaterScript.Update() called");
		int index = (int)(Time.timeSinceLevelLoad * fps);
		if (to.running) {
			index = index % sprites.Length;
		} else {
			index = 0;
		}
		
		//transform.localScale = new Vector3 (90, 90, 90);
		// Set the y-direction scale to be full when we hit 100% of our run time.
		//if (to.runSec / to.workSpan.TotalSeconds > 0.03) {
		//yscale = 10 + (to.runSec / to.workSpan.TotalSeconds * 90);
		//transform.localScale = new Vector3(90,90,90);
		
		//}
		//Debug.Log ("yscale = " + yscale);
		spriteRenderer.sprite = sprites [index];
	}
}

