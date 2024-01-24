using UnityEngine;

public class Movement : MonoBehaviour
{
    // Update is called once per frame
    public void FixedUpdate()
    {
        float angleDelta = 1.0f;
        float positonDelta = 0.1f;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(angleDelta, 0, 0);
            }
            if (Input.GetKey("a"))
            {
                transform.Rotate(-angleDelta, 0, 0);
            }
            if (Input.GetKey("w"))
            {
                transform.Rotate(0, angleDelta, 0);
            }
            if (Input.GetKey("s"))
            {
                transform.Rotate(0, -angleDelta, 0);
            }
            if (Input.GetKey("z"))
            {
                transform.Rotate(0, 0, angleDelta);
            }
            if (Input.GetKey("c"))
            {
                transform.Rotate(0, 0, -angleDelta);
            }
        }
        else
        {
            if (Input.GetKey("d"))
            {
                // transform.position += new Vector3(0.1f, 0, 0);
                transform.Translate(0.1f, 0, 0);
            }
            if (Input.GetKey("a"))
            {
                transform.Translate(-0.1f, 0, 0);
            }
            if (Input.GetKey("w"))
            {
                transform.Translate(0, 0.1f, 0);
            }
            if (Input.GetKey("s"))
            {
                transform.Translate(0, -0.1f, 0);
            }
            if (Input.GetKey("z"))
            {
                transform.Translate(0, 0, 0.1f);
            }
            if (Input.GetKey("c"))
            {
                transform.Translate(0, 0, -0.1f);
            }
        }
    }
}
