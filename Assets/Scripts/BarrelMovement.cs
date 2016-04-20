using UnityEngine;
using System.Collections;

public class BarrelMovement : MonoBehaviour
{

    public GameObject character;
    Vector3 newPosition;
    float speed = 0.5F;
    int[] xGoals = {80,80,87,93,96,107,117,130,154,174,194,209,226,238,
                    254,272,295,320,341,367,386,404,417,423,416,408,397,
                    380,350,327,307,288,270,252,228,209,188,167,142,133,
                    123,118,123,129,139,150,159,172,190,203,220,237,260,
                    293,335,372,390,407,418,429,441,450,460,475,485};
    int[] zGoals = {520,492,468,436,411,391,374,352,338,338,342,351,356,362,
                    372,380,387,387,378,362,342,331,308,277,235,217,196,
                    176,164,164,169,180,189,194,205,208,205,205,199,191,
                    180,156,135,119,99,86,74,69,59,54,44,36,33,
                    34,34,34,38,50,64,79,97,110,131,147,163}; 
    int xGoal;
    int zGoal;
    int stage = 0;

    // Use this for initialization
    void Start()
    {
        newPosition = character.transform.position;
        xGoal = xGoals[stage];
        zGoal = zGoals[stage];
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 lookDest = new Vector3(xGoals[stage + 1], 18, zGoals[stage + 1]);
        character.transform.LookAt(lookDest);

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

            if (stage == xGoals.Length - 1)
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
            Debug.Log("X: " + character.transform.position.x + " Z: " + character.transform.position.z);

        }//end if

    }//end update

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