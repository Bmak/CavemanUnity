using UnityEngine;
using System.Collections;

public class MokarController : MonoBehaviour 
{
    int speed = 10;

    float vx = 0;
    float vy = 0;
    float targetX = 0;
    float targetY = 0;

	
	// Update is called once per frame
	void Update () 
    {
	    if (Input.GetMouseButtonDown(0))
	    {
            print("move");
	        Move();
	    }

        var pos = transform.position;
        pos.x = pos.x + vx * Time.deltaTime;
        pos.y = pos.y + vy * Time.deltaTime;
        transform.position = pos;
	}

    public void Move()
    {
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);



        Debug.Log(pos);
        targetX = pos.x;
        targetY = pos.y;

        var heroPos = transform.position;

        float dx = targetX - heroPos.x;
        float dy = targetY - heroPos.y;
        float d = Mathf.Sqrt(dx * dx + dy * dy);

        if (d != 0)
        {
            vx = (dx / d) * speed;
            vy = (dy / d) * speed;
        }
    }
}
