using UnityEngine;
[RequireComponent(typeof(PlatformerCharacter2D))]
public class Platformer2DUserControl : MonoBehaviour 
{
	private PlatformerCharacter2D character;
    private bool jump;

	void Awake()
	{
		character = GetComponent<PlatformerCharacter2D>();
	}

	void FixedUpdate()
	{
        //// Read the jump input in Update so button presses aren't missed.
        //if (Input.GetButtonDown("Jump"))
        //{
        //    jump = true;
        //}
        //
        //float h = Input.GetAxis("Horizontal");
        //character.Move( h , jump );
        //jump = false;
	}

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //character.Move(1.0f, true);
        }
    }
}
