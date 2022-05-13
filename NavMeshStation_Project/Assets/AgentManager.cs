using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    //Array de agentes para alocar os agentes da cena
    GameObject[] agents;

    //Quando a cena é iniciada
    void Start()
    {
        //Encontra objetos com a tag "ai" e atribui à variável
        agents = GameObject.FindGameObjectsWithTag("ai");
    }
    
    //Uma vez por frame
    void Update()
    {
        //Caso o jogador clique
        if (Input.GetMouseButtonDown(0))
        {
            //Variável para receber valor do raycast
            RaycastHit hit;
            //Cria raycast com origem da câmera até o objeto
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000))
            {
                //Para cada objeto cujo foi atribuído na variável "agents"
                foreach (GameObject a in agents)
                    //Move o objeto em direção ao ponto informado advinddo raycast
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
