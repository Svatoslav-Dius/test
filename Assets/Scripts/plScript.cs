using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plScript : MonoBehaviour
{

    public Vector3 positionPlayer;
    public Color colorPlayer;
    public Rigidbody2D rbPlayer;
    public Transform transformPlayer;
    public Transform transformOther;
    public SpriteRenderer characterAppearance;
    public GameObject circle;
    public Transform positionPrefab;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Pink Character";
        rbPlayer.mass = 5;
        transformPlayer.position = transformOther.position;
        characterAppearance.color = colorPlayer;

        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        rigidbody.mass = 6;
        rigidbody.gravityScale = 3;
        GetComponent<Transform>().position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(circle, positionPrefab.position, Quaternion.identity, positionPrefab);
        }
    }
}
