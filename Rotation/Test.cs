using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 mouseClickPos;
    float angle;
    float lastAngle;
    int fullRotations;
    public float realAngle;
    void Update()
    {
        mouseClickPos = Input.mousePosition;    
        Vector3 dir = mouseClickPos - Camera.main.WorldToScreenPoint(transform.position);
        angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
        angle-=90;
        
        if(lastAngle - angle > 270){
            fullRotations ++;
        }else if(angle - lastAngle > 270){
            fullRotations --;
        }
        
        lastAngle = angle;
        
        Debug.Log(360*fullRotations + angle);
    }
}
