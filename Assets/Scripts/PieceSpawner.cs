using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceSpawner : MonoBehaviour
{
    //Array donde guardamos los objetos que serán spawneados
    public GameObject[] levelPieces;

    // Start is called before the first frame update
    void Start()
    {
        //Sacará una pieza al azar al empezar el juego
        SpawnNextPiece();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Método para spawnear piezas
    public void SpawnNextPiece()
    {
        //Tomamos un valor aleatorio comprendido en la longitud de todo el array
        int i = Random.Range(0, levelPieces.Length); //Random.Range(valor más bajo, valor más alto)

        //Instanciamos la pieza seleccionada en la posición del objeto spawneador
        Instantiate(levelPieces[i], this.transform.position, Quaternion.identity); //Quaternion.identity es la rotación que tuviera en ese momento el objeto spawneador
        //Instantiate(objeto a instanciar, posición en la que se instancia, rotación con la que se instancia)

    }
}
