using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Level_5
{
    public class Chargebar : MonoBehaviour
    {
        [SerializeField] private GameObject m_chargebar;

        [SerializeField] private GameObject m_trigger;

        [SerializeField] private EndObjectivePhaseTwo m_EndPhase;

        public bool m_Charged;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (m_chargebar.transform.localScale.x <= 1 && m_chargebar.transform.localScale.x >= 0.025)
            {
                m_chargebar.transform.localScale -= new Vector3(0.005f, 0, 0);
            }
            if (m_trigger.GetComponent<Chargetrigger>().m_canTrigger == true && m_chargebar.transform.localScale.x <= 1)
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    m_chargebar.transform.localScale += new Vector3(0.1f, 0, 0);
                }
            }
            if (m_chargebar.transform.localScale.x >= 1)
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    m_EndPhase.GrabPart();
                    Debug.Log("yes");
                }
                
            }
        }
    }
}


