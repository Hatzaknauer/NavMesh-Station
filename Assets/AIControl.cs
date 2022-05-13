using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIControl : MonoBehaviour
{
    //Variável para alocar as propriedades do agente
    public NavMeshAgent agent;

    //Quando a cena é iniciada
    void Start()
    {
        //Aloca a propriedade NavMeshAgent na variável assim que a cena é iniciada
        agent = this.GetComponent<NavMeshAgent>();
    }
}
