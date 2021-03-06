﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionSouris : MonoBehaviour
{

    //public float vitesse = 10f;
    public static float vitesse = GestionLevel.vitesseCourante;
    private static float vitesseAveugle = vitesse;
    public static float arret = 0f;
    public GameObject positionFinNiveau;
    private Vector3 startPos;
    private Vector3 TargetPosition;

    public GameObject targetPositionObject;
    private Vector3 positionJoueur;
    private GameObject objetPositionPerso;
    private bool estMarcher;

    private Animator animator;
    public AudioClip bark;
    public AudioSource source;

    // Use this for initialization
    void Start()
    {

        TargetPosition = positionFinNiveau.transform.position;

        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("estMarcher", true);

    }

    // Update is called once per frame
    void Update()
    {
        print(GestionLevel.pause);

        if (!GestionLevel.pause)
        {

            transform.position += transform.forward * vitesse * Time.deltaTime;

            // Fait venir aveugle a la position du chien
            if (Input.GetMouseButtonUp(0))
            {
                vitesse = vitesseAveugle;
                animator.SetBool("estMarcher", true);
                positionJoueur = GameObject.Find("Player").transform.position;
                objetPositionPerso = Instantiate(targetPositionObject, positionJoueur, Quaternion.identity);


                objetPositionPerso.name = "objetPositionPerso";
                print(objetPositionPerso.transform.position);
                transform.LookAt(objetPositionPerso.transform);

                source.PlayOneShot(bark);
            }


            // Fait arrêter aveugle
            if (Input.GetMouseButtonUp(1))
            {
                source.PlayOneShot(bark);
                vitesse = arret;
                animator.SetBool("estMarcher", false);

            }
        }

    }

    public static void arretDeplacement()
    {
        vitesse = arret;

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "zonePointAveugle")
        {

            Destroy(objetPositionPerso);
            TargetPosition = positionFinNiveau.transform.position;

        }


    }


}
