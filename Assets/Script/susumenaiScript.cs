using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class susumenaiScript : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.position = new Vector2(
            //ƒGƒŠƒAŽw’è‚µ‚ÄˆÚ“®‚·‚é
            Mathf.Clamp(transform.position.x + moveX, -8.0f, 8.0f),
            Mathf.Clamp(transform.position.y + moveY, -4.25f, 4.25f)
            );
    }
}