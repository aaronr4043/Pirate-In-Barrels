using UnityEngine;
using System.Collections;

public class testCubeMove : MonoBehaviour {

    public GameObject character;
    Vector3 newPosition;
    float speed = 0.5F;
    //int[] xGoals = { 0, 0, -50, -50, -25, -25 };
    int[] xGoals = {90,90,106,141,181,218,250,285,324,357,373,414,414,427, 418,
                    403,383,349,320,298,265,238,197,154,117,117,126,153,175, 195,
                    227, 262, 295, 339, 366,403,423,439,450,446,483,511};
    //int[] zGoals = { 0, 50, 50, -50, -50, 0 };
    int[] zGoals = {505, 424,385,346,346,360,374,386,386,369,357,319,265,263,220,190,
                    169,158,164,180,195,206,206,199,180,147,121,87,70,59,43,37,35,35,
                    41,48,65,90,116,140,158,164};
    int xGoal;
    int zGoal;
    int stage = 0;
    //42 stages

    // Use this for initialization
    void Start () {
        newPosition = character.transform.position;
        xGoal = xGoals[stage];
        zGoal = zGoals[stage];

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 lookDest = new Vector3(xGoals[stage+1],25,zGoals[stage+1]);
        character.transform.LookAt(lookDest);
        //var startPosition : Vector3 = Vector3
        if (!((newPosition.x < xGoal + 1 && newPosition.x > xGoal - 1) && (newPosition.z < zGoal + 1 && newPosition.z > zGoal - 1)))
        {
            if (newPosition.x > xGoal)
            {
                xDecrease();

            }//end if
            else
            {
                xIncrease();

            }//end else


            if (newPosition.z > zGoal)
            {
                zDecrease();

            }//end if z
            else
            {
                zIncrease();

            }

        }//end check if not at goal
        else
        {
            stage++;
            xGoal = xGoals[stage];
            zGoal = zGoals[stage];

            if (stage == xGoals.Length-1)
            {
                stage = 0;
            }

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x++;
            character.transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x--;
            character.transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newPosition.z++;
            character.transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newPosition.z--;
            character.transform.position = newPosition;

        }//end if statements for movement
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("X: " + xGoals.Length + "Z: " + zGoals.Length);

        }//end if
    }
    void xIncrease()
    {
        newPosition.x += 1 * speed;
        character.transform.position = newPosition;

    }//end xIncrement

    void xDecrease()
    {
        newPosition.x -= 1 * speed;
        character.transform.position = newPosition;

    }//end xDecrease

    void zIncrease()
    {
        newPosition.z += 1 * speed;
        character.transform.position = newPosition;

    }

    void zDecrease()
    {
        newPosition.z -= 1 * speed;
        character.transform.position = newPosition;

    }//end zDecrease

}
