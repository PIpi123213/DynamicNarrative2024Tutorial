using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �����ײ�Ķ����Ƿ��ǽ�ɫ
        if (collision.gameObject.CompareTag("Player") )
        {
            Rigidbody2D playerRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();

            
            if (playerRigidbody != null)
            {
                
                playerRigidbody.gravityScale = 0.3f;
            }
        }
    }
}
