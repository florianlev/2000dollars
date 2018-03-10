using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuiviChien : MonoBehaviour
{


    public GameObject cible;
    public static float vitesse = 5.25f;
    private Rigidbody body;
    private Vector3 targetPosition;
    private bool enMouvement;
    private Vector3 positionJoueur;


    // Use this for initialization
    void Start()
    {


        enMouvement = false;
    }

    // Update is called once per frame
    void Update()
    {

        positionJoueur = GameObject.Find("Chien").transform.position;
        targetPosition = positionJoueur;

        if (Input.GetMouseButton(0))
        {
            setPositionAveugle();
        }
        if (Input.GetMouseButton(1))
        {
            stopAveugle();
        }

        if (enMouvement)
        {
            mouvementAveugle();

        }


    }

    void setPositionAveugle()
    {

        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0f;

        if (plane.Raycast(ray, out point))
            targetPosition = ray.GetPoint(point);

        enMouvement = true;
    }

    void mouvementAveugle()
    {


        transform.LookAt(positionJoueur);
        transform.position = Vector3.MoveTowards(transform.position, positionJoueur, vitesse * Time.deltaTime);

        if (transform.position == targetPosition)
        {
            enMouvement = false;
        }
    }



    void stopAveugle()
    {

    }
}
