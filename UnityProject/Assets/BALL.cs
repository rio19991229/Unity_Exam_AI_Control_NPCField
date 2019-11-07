using UnityEngine;

public class BALL : MonoBehaviour
{
    [Header("Move Speed")]
    public float speed = 20f;
    [Header("Jump Height")]
    public float jump = 50f;
    public bool isGround = false;


    private Transform trf;
    private Rigidbody r3d;
   


    private void Start()
    {
        trf = GetComponent<Transform>();
        r3d = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {
        Walk();
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
        Debug.Log("碰到" + collision.gameObject);
    }

                                     /// <summary>
                                    /// 走路
                                    /// </summary>
    void Walk()
    {
        r3d.AddForce(new Vector3(-speed * (Input.GetAxis("Vertical")), 0,speed  * (Input.GetAxis("Horizontal"))));
    }
                                  /// <summary>
                                  /// 跳躍
                                  /// </summary>
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = true;
            r3d.AddForce(new Vector3(0, jump,0 ));
        }
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    /// <param></param>
    private void Jump(int jump = 0)
    {
        transform.eulerAngles = new Vector3(0, jump, 0);
    }
}
