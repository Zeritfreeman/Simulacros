using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public static int codigo = 0; // 0 Primer simulacro. 1 Segundo simulacro

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= 3) salida++;
        }

        
        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------


        for (int j = 0; j < nombres.Length; j++)
        {
            for (int i = 0; i < notas.Length - 1; i++)
            {
                if (notas[i] > notas[i + 1])
                {
                    double notaTempo = notas[i + 1];
                    notas[i + 1] = notas[i];
                    notas[i] = notaTempo;

                    string nombreTempo = nombres[i + 1];
                    nombres[i + 1] = nombres[i];
                    nombres[i] = nombreTempo;
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            salida[i] = nombres[i];
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        int contador = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= 3) contador++;
        }

        salida = new string[contador];
        int contador2 = 0;

        for (int i = 0; i < nombres.Length; i++)
        {
            if (notas[i] <= 3)
            {
                salida[contador2] = nombres[i];
                contador2++;
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        int contador = 0;

        for (int i = 0; i < nombres.Length; i++)
        {
            for (int j = 0; j < nombres[i].Length; j++)
            {
                char letra = nombres[i][j];
                if (letra == 'A')
                {
                    contador++;
                    break;
                }
            }
        }

        salida = new string[contador];
        int contador2 = 0;

        for (int i = 0; i < nombres.Length; i++)
        {
            for (int j = 0; j < nombres[i].Length; j++)
            {
                char letra = nombres[i][j];
                if (letra == 'A')
                {
                    salida[contador2] = nombres[i];
                    contador2++;
                    break;
                }
            }
        }
        //- Arriba de esta línea va su código --------
        return salida;
    }
}


