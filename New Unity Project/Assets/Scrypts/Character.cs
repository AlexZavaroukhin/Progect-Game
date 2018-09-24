using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //Player's movement speed
    [SerializeField]
    private float speed;

    protected Vector2 direction;  //позволяет решать НАМ в каком направлении двигаться

    protected Animator animator;

    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	protected virtual void Update ()
    {
        Move(); //активируем функцию Move;
    }

    //Move's the player
    public void Move()
    {
        //Make's sure that player moves
        transform.Translate(direction * speed * Time.deltaTime); //заставляет персонажа двигаться вправо

        AnimateMovement(direction);
    }


    public void AnimateMovement(Vector2 direction)
    {
        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
    }

}
