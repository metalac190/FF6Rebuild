using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour
{
    [SerializeField] Color _gizmoColor = Color.red;
    [SerializeField] float _length = 10;
    [SerializeField] float _height = 0;
    [SerializeField] float _width = 10;

    public Vector3 GetSpawnLocation(Vector3 normalizedPosition)
    {
        // convert x position
        float minXPos = transform.position.x - (_length/2);
        float maxXPos = transform.position.x + (_length / 2);
        float newXPos = Mathf.Lerp(minXPos, maxXPos, normalizedPosition.x);
        // convert y position
        float minYPos = transform.position.y - (_height / 2);
        float maxYPos = transform.position.y + (_height / 2);
        float newYPos = Mathf.Lerp(minYPos, maxYPos, normalizedPosition.y);
        // convert z position
        float minZPos = transform.position.z - (_width / 2);
        float maxZPos = transform.position.z + (_width / 2);
        float newZPos = Mathf.Lerp(minZPos, maxZPos, normalizedPosition.z);

        // ignoring vertical since we're using 3D space, but positioning with X/Y values
        Vector3 newSpawnPosition = new Vector3(newXPos, newYPos, newZPos);

        return newSpawnPosition;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _gizmoColor;
        Gizmos.DrawWireCube(transform.position, new Vector3(_length, _height, _width));
    }
}
