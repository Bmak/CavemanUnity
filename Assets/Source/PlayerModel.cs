using Caveman;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class PlayerModel : MonoBehaviour
{
    private const int Speed = 2 ;
    public Player player;

    private Vector2 positionDelta;

    public void Start ()
    {
        transform.position = Vector2.zero;
    }
	
	public void Update ()
	{
	    if (Input.GetMouseButton(0))
	    {
            positionDelta = CalculateDelta(Camera.main.ScreenToWorldPoint(Input.mousePosition));
	    }
        transform.position = new Vector3(transform.position.x + positionDelta.x * Time.deltaTime, transform.position.y + positionDelta.y * Time.deltaTime);

	}

    private Vector2 CalculateDelta(Vector2 positionTarget)
    {
        var dx = positionTarget.x - transform.position.x;
        var dy = positionTarget.y - transform.position.y;
        var d = Mathf.Sqrt(dx * dx + dy * dy);
        return d != 0 ? new Vector2((dx / d) * Speed, (dy / d) * Speed) : Vector2.zero;
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        print("OnCollisionEnter2D");
        if (coll.gameObject.tag == "Enemy")
            coll.gameObject.SendMessage("ApplyDamage", 10);

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        print("OnTriggerEnter2D");
    }
}
