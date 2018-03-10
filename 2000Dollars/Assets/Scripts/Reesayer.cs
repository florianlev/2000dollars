using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reesayer : MonoBehaviour {

	public void Ressayer()
    {

        print("test");

        UnityEngine.SceneManagement.SceneManager.LoadScene("Level "+GestionLevel.level);
    }

}
