using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player : MonoBehaviour
{

    [SerializeField] private CharacterController controller;
    public NavMeshAgent myAgent;
    public GameObject effectPrefab;
    private Animator animator;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                myAgent.SetDestination(hit.point);
                Vector3 spawnPosition = hit.point + new Vector3(0, 0.1f, 0);
                Quaternion spawnRotation = Quaternion.Euler(-90, 0, 0);
                GameObject effect = Instantiate(effectPrefab, spawnPosition, spawnRotation);

                Destroy(effect, 0.6f);
            }
        }

        // Calculate movement direction and speed based on NavMeshAgent
        moveDirection = myAgent.velocity.normalized;
        float speed = myAgent.velocity.magnitude;
        animator.SetFloat("Speed", speed);

        // Move character using CharacterController
        controller.Move(moveDirection * Time.deltaTime * speed);
    }
}
