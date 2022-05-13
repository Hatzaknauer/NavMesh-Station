using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    //Array de agentes para alocar os agentes da cena
    GameObject[] agents;

    //Quando a cena � iniciada
    void Start()
    {
        //Encontra objetos com a tag "ai" e atribui � vari�vel
        agents = GameObject.FindGameObjectsWithTag("ai");
    }
    
    //Uma vez por frame
    void Update()
    {
        //Caso o jogador clique
        if (Input.GetMouseButtonDown(0))
        {
            //Vari�vel para receber valor do raycast
            RaycastHit hit;
            //Cria raycast com origem da c�mera at� o objeto
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000))
            {
                //Para cada objeto cujo foi atribu�do na vari�vel "agents"
                foreach (GameObject a in agents)
                    //Move o objeto em dire��o ao ponto informado advinddo raycast
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
