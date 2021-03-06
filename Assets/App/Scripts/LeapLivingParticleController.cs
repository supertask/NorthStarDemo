﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapLivingParticleController : MonoBehaviour {

    public Transform affector;
    public Transform eyes; //usually the object "AR headset Halo Small BOE unity optimized Rev 2 internal rigel"
    private ParticleSystemRenderer psr;

	void Start () {
        psr = GetComponent<ParticleSystemRenderer>();
	}
	
	void Update () {
        this.setAffectorPosition();
    }

    private void setAffectorPosition()
    {
        if (this.affector != null)
        {
            if (Input.GetKey(KeyCode.W)) {
                this.affector.position += new Vector3(0, 0, 0.02f);
            }
            else if (Input.GetKey(KeyCode.S)) {
                this.affector.position += new Vector3(0, 0, -0.02f);
            }
            else if (Input.GetKey(KeyCode.D)) {
                this.affector.position += new Vector3(0.02f, 0, 0);
            }
            else if (Input.GetKey(KeyCode.A)) {
                this.affector.position += new Vector3(-0.02f, 0, 0);
            }
            this.psr.material.SetVector("_Affector", this.affector.position);
        }

        if (this.eyes != null) {
            float rotateRate = 0.1f;
            if (Input.GetKey(KeyCode.J)) {
                if (Input.GetKey(KeyCode.RightShift)) {
                    this.eyes.Rotate(new Vector3(rotateRate, 0, 0));
                } else {
                    this.eyes.Rotate(new Vector3(-rotateRate, 0, 0));
                }
            }
            else if (Input.GetKey(KeyCode.K)) {
                if (Input.GetKey(KeyCode.RightShift)) {
                    this.eyes.Rotate(new Vector3(0, rotateRate, 0));
                } else {
                    this.eyes.Rotate(new Vector3(0, -rotateRate, 0));
                }
            }
            else if (Input.GetKey(KeyCode.L)) {
                if (Input.GetKey(KeyCode.RightShift)) {
                    this.eyes.Rotate(new Vector3(0, 0, rotateRate));
                } else {
                    this.eyes.Rotate(new Vector3(0, 0, -rotateRate));
                }
            }
        }
    }
}
