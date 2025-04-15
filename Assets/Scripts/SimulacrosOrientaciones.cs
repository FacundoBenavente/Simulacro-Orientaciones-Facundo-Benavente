using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulacrosOrientaciones : MonoBehaviour
{
    public string nombreAlumno;
    public int añoAlumno;
    public string especialidad;
    // Start is called before the first frame update
    void Start()
    {
        if(nombreAlumno == "")
        {
            Debug.Log("El usuario debe escribir su nombre para continuar");
        } else if(añoAlumno < 1 || añoAlumno > 5)
        {
            Debug.Log("El año seleccionado no esta en el rango possible");
        } else if(añoAlumno < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        } else if (especialidad != "T" && especialidad != "D" && especialidad != "G" && especialidad != "M" && especialidad != "H")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }
        else
        {
            Debug.Log("Muchas gracias " + nombreAlumno);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
