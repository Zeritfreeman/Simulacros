using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public static int codigo = 1; // 0 Primer simulacro. 1 Segundo simulacro

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

        double sumatoria = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            sumatoria += notas[i];
        }

        double promedio = sumatoria / notas.Length;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= promedio) salida++;
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

        double sumatoria = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            sumatoria += notas[i];
        }

        double promedio = sumatoria / notas.Length;
        double[] diferencias = new double[notas.Length];

        for (int i = 0; i < diferencias.Length; i++)
        {
            diferencias[i] = Math.Abs(promedio - notas[i]);
        }

        for (int j = 0; j < nombres.Length; j++)
        {
            for (int i = 0; i < diferencias.Length - 1; i++)
            {
                if (diferencias[i] > diferencias[i + 1])
                {
                    double diferenciaTempo = diferencias[i + 1];
                    diferencias[i + 1] = diferencias[i];
                    diferencias[i] = diferenciaTempo;

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
        /*for (int j = 0; j < nombres.Length; j++)
        {
            for (int i = 0; i < nombres.Length - 1; i++)
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

        int posicion = 0;

        for (int i = 0; i < nombres.Length; i++)
        {
            if (Math.Abs(promedio - notas[i]) < diferencia)
            {
                diferencia = Math.Abs(promedio - notas[i]);
                posicion = i;
            }
            else break;
        }

        salida[0] = nombres[posicion];
        int contador = 1;
        
        for (int i = 1; i < 4; i++)
        {
            if (Math.Abs(promedio - notas[posicion + i]) > Math.Abs(promedio - notas[posicion - i]))
            {
                double notaTempo = notas[posicion + i];
                notas[posicion + i] = notas[posicion - i];
                notas[posicion - i] = notaTempo;

                string nombreTempo = nombres[posicion + i];
                nombres[posicion + i] = nombres[posicion - i];
                nombres[posicion - i] = nombreTempo;

                salida[contador] = nombres[posicion + i];
                contador++;
            }
            else
            {
                salida[contador] = nombres[posicion + i];
                contador++;
            }
        }*/

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        double sumatoria = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            sumatoria += notas[i];
        }

        double promedio = sumatoria / notas.Length;
        int longitud = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= promedio) longitud++;
        }

        salida = new string[longitud];
        int posicion = 0;

        for (int i = 0; i < nombres.Length; i++)
        {
            if (notas[i] >= promedio)
            {
                salida[posicion] = nombres[i];
                posicion++;
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
            char letraInicial = nombres[i][0];

            if (letraInicial == 'A' || letraInicial == 'E' || letraInicial == 'I' || letraInicial == 'O' || letraInicial == 'U')
            {
                contador++;
            }
        }

        salida = new string[contador];
        int posicion = 0;

        for (int i = 0; i < nombres.Length; i++)
        {
            char letraInicial = nombres[i][0];

            if (letraInicial == 'A' || letraInicial == 'E' || letraInicial == 'I' || letraInicial == 'O' || letraInicial == 'U')
            {
                salida[posicion] = nombres[i];
                posicion++;
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }
}


