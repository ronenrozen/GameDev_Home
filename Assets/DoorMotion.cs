using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    MainCamera camera;
    public int threshold = 1;
    int isOutside = 1;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.findGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = camera.transform.position();
        Vector3 doorPosition = this.transform.position();
        if (isClose){

            if (transform.rotate.y  < 0 || transform.rotate.y > 90) {
                isOutside = isOutside * -1;
            }
            transform.rotate.y += 0.5 * isOutside;
        }
    }

    boolean isClose(Vector3 cameraPosition,Vector3 doorPosition )
    {
        return Math.abs(cameraPosition.x - doorPosition.x) < threshold && Math.abs(cameraPosition.y - doorPosition.y) < threshold && Math.abs(cameraPosition.z - doorPosition.z) < threshold;
    }
}
