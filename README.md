# in-class-activities
## Devlogs
### W1
1. The camera is fixed. When I move the cat, the camera does not follow my cat. It is because "GameObjects that are nested below another object in the hierarchy will move with that object", but the camera is not below the cat's hierarchy.
2. [itch.io link](https://yizonglu-kx.itch.io/w1-in-class-activity)

### W2
1. It is because the the values of r, g, and b are from 0.0 to 0.1. They are fractional numbers.
2. It is because _bounce variable counts the number of the ball bounced and it is an interger.
3. There is no ";" at the end.

### W3

#### Activity 1 table 9

1. The parameters are an int about the player’s current friendship level with the character and a bool about a flag that tells you whether or not the player knows the character’s secret. The return type is a string about the character's text response.
2. The parameters is a float about the player's sanity level.
3. The parameter is a float of the time the player hit the beat. The return type is a bool about whether or not the player accurately hit a beat.

#### Activity 2

A class is recipie of a cheeseburger, and Components is a whole cheeseburger. The method is how to cook the patty, and the member variables are the cheese and lettuces. 

#### Acticity 3

It is because the average speed is greater than speed threshold, and the balls bounce many times. Balls will become brigher if they bounce more. Their brightness will keep multiplying the multiplier of 1.5 while the balls bouncing, so balls will be extremely bright.

### W4 

Table 7
1. I added Rigidbodies to Cat and SoccerBall and checked Is Trigger on the collider of Goal.
2. My SoccerBall moved without inertia at first. It is because when I check Freeze Rotation on the X and Z axes of Cat, I also check these boxes of SoccerBall. When I uncheck them, the SoccerBall moves like the one in the example.

### W6

1. It needs a Transform variable to get the Transform of the target which the Deer will walk toward, and It needs a NavMeshAgent variable to get the NavMeshAgent Component on the Deer gameObject.
2. It needs two method one Start() method and one Update() method which are both Unity provided.
3. Start() method is used to initialize the NavMeshAgent variable by using GetComponent<> to get the NavMeshAgent Component on the Deer gameObject. Update() method is used to call SetDestination of the NavMeshAgent to the position of the target every frame so that the deer will walk toward the target every frame as AI navigation.

### W7

My category is Unity Coding.

[Class resource guide](https://docs.google.com/document/d/179zDHWaZxqnBjZy0PR_jNnTRrSRR3sZZ_zDTDfMMah8/edit?tab=t.0)

1. It needs a float variable _speed to store the speed of every bat, a Transform variable _playerTransform to store the Transform of player in order to get the position of player, and a bool variable _is_chase to store whether the bat is chasing player or not.
2. It needs a Start() method, an Update() method, a method StartChase(), and a method StopChase().
3. In Start(), it will initialize _is_chase to true so that the bat will chase the player. In Update(), it will check whether this bat is chasing the player by using _is_chase bool variable. If the bat is chasing the player, the position of this bat will change to the position where the bat move distance of _speed times Time.deltatime towards the player in every frame. In StartChase(), it will change _is_chase to true, which means the bat will chase the player after call this method. In StopChase(), it will change _is_chase to false, which means the bat will not chase the player after call this method.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
