// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     public float speed = 1f;
    
//     private float Y_LIMIT= 4.6f;
//     private float X_LIMIT=8;
//     private PlayerInputAction inputActions;
//         void Start()
//     {
//         inputActions=new();
//         inputActions.Enable();
//         inputActions.Standard.Enable();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//        var upDown = inputedActions.Instance.verticalMove.ReadValue<float>();
//        this.transform.Translate(Vector3.up * speed * Time.deltaTime * upDown);

//        if (this.transform.position.y > Y_LIMIT)
//         {
//             this.transform.position= new Vector3(transform.position.x,Y_LIMIT);
//         }
//         else if (this.transform.position.y < -Y_LIMIT)
//         {
//             this.transform.position= new Vector3(transform.position.x, -Y_LIMIT);
//         }

//         var leftRight= inputedActions.Instance.input.horizontalMove.ReadValue<float>();
//         this.transform.Translate(Vector3.right * speed * Time.deltaTime * leftRight);

//         if (this.transform.position.x > X_LIMIT)
//         {
//             this.transform.position= new Vector3(X_LIMIT, transform.position.y);

//         }
//         else if (this.transform.position.x < -X_LIMIT)
//         {
//             this.transform.position= new Vector3(-X_LIMIT, transform.position.y);
//         }
//     }
// }