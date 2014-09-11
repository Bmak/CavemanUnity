using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    public Transform TargetPosition;
    public float smoothTime = 0.3F;

    private Vector3 velocity = Vector3.zero;
	
	void FixedUpdate ()
	{
	    if (TargetPosition != null)
	    {
            var smoothPosHero = Vector3.SmoothDamp(transform.position, TargetPosition.position, ref velocity, smoothTime);    
            // todo -10 
            transform.position = new Vector3(smoothPosHero.x, smoothPosHero.y, -10);
	    }
	}
}
