using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIControl : MonoBehaviour
{
    //Vari�vel para alocar as propriedades do agente
    public NavMeshAgent agent;

    //Quando a cena � iniciada
    void Start()
    {
        //Aloca a propriedade NavMeshAgent na vari�vel assim que a cena � iniciada
        agent = this.GetComponent<NavMeshAgent>();
    }
}
