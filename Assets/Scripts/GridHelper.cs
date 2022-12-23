using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHelper : MonoBehaviour
{
    /* Matriz filas y columnas
      |  0  |  1  |  2  |  3  |
   -----------------------------
    0 | null   x     x    null
    1 |  x     x    null  null
    2 | null  null  null  null
    3 | null  null  null  null
     
     */

    //Ancho y alto de la rejilla
    //Son estáticas para poder instanciarlas sin tener que consultar el objeto
    public static int w = 10, h = 18 + 4;
    //Creamos el array doble rejilla, de altura y anchura dada
    public static Transform[,] grid = new Transform[w, h]; //La [,] indica dos dimensiones

    //Método que dado un Vector2 cogerá ese Vector, y redondeará sus coordenadas de X e Y. Tras esto el método nos devuelve el vector redondeado
    public static Vector2 RoundVector(Vector2 v)
    {
        //Devuelve un nuevo Vector2 ya redondeado en X e Y
        return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y)); //Mathf.Round -> redondea al número entero más próximo
    }

    //Método que dada una posición comprobamos si esta pieza está dentro de los bordes del juego. Nos devolverá si es cierto o no
    public static bool IsInsideBorders(Vector2 pos)
    {
        //Si ambas coordenadas son positivas y no se pasan por la derecha
        if (pos.x >= 2 && pos.y >= 0 && pos.x < w + 2)
        {
            //La pieza está dentro de la zona de juego
            return true;
        }
        //Si lo de arriba no se cumple
        else
        {
            //La pieza está fuera de la zona de juego
            return false;
        }
    }
}
