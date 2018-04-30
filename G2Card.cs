using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G2Card : MonoBehaviour
{
	G2Manager G2M;
    public float Speed = 5f;
	public bool IsSafeMark = false;

    // Use this for initialization
    void Start()
    {
		G2M = GameObject.Find("G2Manager").GetComponent<G2Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -Time.deltaTime * Speed, 0);//移動方法
    }

    public void OnMouseDown()
    {
		if (IsSafeMark)
		    G2M.AddTotalScore();
		else
			G2M.SubTotalScore();
		
        Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "floor")
        {
            if (IsSafeMark)
                G2M.SubTotalScore();

            Destroy(this.gameObject);
        }
            
    }

	//----------------------------------
	public void SetSpeed(float speed)
	{
		Speed = speed;
	}
}
