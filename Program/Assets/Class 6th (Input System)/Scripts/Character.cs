using UnityEngine;

public class character : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Vector3 direction;
    [SerializeField] float speed;
    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // Time.deltaTime
        // 이전 프레임에서 현재 프레임까지 걸린 시간입니다.

        direction.Normalize();

        transform.position += direction * Time.deltaTime * speed;
    }
}
