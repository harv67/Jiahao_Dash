using UnityEngine;

public class TriggerCam : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float LevelTrigger = 1f;
    private float LowLevel = 0f;
    private float HighLevel = 1f;
    [SerializeField] float smoothSwitch = 3f;
    

    void Update()
    {
        float playerY = player.position.y;

        if (playerY > LevelTrigger)
        {
            float newY = Mathf.Lerp(transform.position.y, HighLevel, smoothSwitch * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
        else 
        {
            float newY = Mathf.Lerp(transform.position.y, LowLevel, smoothSwitch * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
       
    
    }

}
