using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private Transform m_Transform;
    private static float previousValue=0;
    public float value;
    public float distance;
    public float size;

    public void moveUp()
    {
        m_Transform = this.gameObject.GetComponent<Transform>();
        value = UIProgressBar.current.value;

        if(previousValue < value){
            distance = (value - previousValue);
            m_Transform.Translate(Vector2.up * distance*5, Space.Self);
        }
        else if(previousValue > value)
        {
            distance = (previousValue - value);
            m_Transform.Translate(Vector2.down * distance * 5, Space.Self);
        }
        previousValue = value;
        
    }
	
}
