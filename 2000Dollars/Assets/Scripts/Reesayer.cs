﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reesayer : MonoBehaviour {

	public void Ressayer()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("Level "+GestionLevel.sceneCourante);
    }

}
