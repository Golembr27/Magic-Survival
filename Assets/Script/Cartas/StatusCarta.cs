using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StatusCarta : MonoBehaviour
{
    public static StatusCarta Instance;
    private void Awake()
    {
        Instance = this;
    }

    public int numeroDeCartasVida = 0;
    public int numeroDeCartasMana = 0;
    public int numeroDeCartasDano = 0;

    public int statusCartaVida = 10;
    public int statusCartaMana = 20;
    public int statusCartaDano = 4;

    private void Start()
    {
        statusCartaVida = 10;
        statusCartaMana = 20;
        statusCartaDano = 4;
    }

}
