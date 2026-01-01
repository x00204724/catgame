using UnityEngine;

public class MobileControls : MonoBehaviour
{
    public float sensitivity = 2f;
    private PlayerController player;
    
    void Start()
    {
        player = GetComponent<PlayerController>();
    }
    
    void Update()
    {
        HandleTouch();
    }
    
    void HandleTouch()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 deltaPosition = touch.deltaPosition;
                transform.Translate(deltaPosition.x * sensitivity * Time.deltaTime, 0, 
                                  deltaPosition.y * sensitivity * Time.deltaTime);
            }
            
            if (touch.phase == TouchPhase.Began && touch.tapCount == 2)
            {
                // Double tap to jump
                GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
            }
        }
    }
}