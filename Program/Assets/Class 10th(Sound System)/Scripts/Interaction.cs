using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;
    [SerializeField] float distance = 100.0f;
    [SerializeField] GameObject target;
    [SerializeField] LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, distance, layerMask))
            {
                AudioSource audioSource = raycastHit.collider.GetComponent<AudioSource>();

                if(audioSource.isPlaying == false)
                {
                    audioSource.Play();
                }
                Debug.Log(raycastHit.collider.gameObject.name);
            }
        }
    }

    private void OnDrawGizmos()
    {
        
        Gizmos.DrawRay(ray.origin, ray.direction*100);
    }
}
