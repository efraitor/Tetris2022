using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceSpawner : MonoBehaviour
{
    //Array donde guardamos los objetos que ser�n spawneados
    public GameObject[] levelPieces;

    // Start is called before the first frame update
    void Start()
    {
        //Sacar� una pieza al azar al empezar el juego
        SpawnNextPiece();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //M�todo para spawnear piezas
    public void SpawnNextPiece()
    {
        //Tomamos un valor aleatorio comprendido en la longitud de todo el array
        int i = Random.Range(0, levelPieces.Length); //Random.Range(valor m�s bajo, valor m�s alto)

        //Instanciamos la pieza seleccionada en la posici�n del objeto spawneador
        Instantiate(levelPieces[i], this.transform.position, Quaternion.identity); //Quaternion.identity es la rotaci�n que tuviera en ese momento el objeto spawneador
        //Instantiate(objeto a instanciar, posici�n en la que se instancia, rotaci�n con la que se instancia)

    }
}
