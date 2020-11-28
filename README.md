# TargetFindingInUnity (Inspired by the work of Code Monkey)
Ways to find a target
1. Using Colliders
2. Using Range method (Vector3.Distance)
3. Using Physics (Overlay)

Consists of the pros and cons of the methods mentioned above

## Way 1 - Collider Target
### Pros
1. Events based, as it uses OnTriggerEnter event
2. Can be easily seen in the Scene View
3. Easy to add Colliders to the Objects
### Cons
1. It is not programmable, and requires colliders. With the nummber of colliders increasing the computation increases with it
2. One gameobject can have only one collider
3. Physics systems plays its role to make the collission work, but in turn it take more computation power

## Way 2 - Calculating distance
### Pros
1. No physics is used, and hence less computation power is required
2. Programmed and controlled via script
### Cons
1. Hit and trial method required to get the required distance, using testing methods

## Way 3 - Using Physics
### Pros
1. Give good performance as it is handle from within the code
### Cons
1. Still required physics based system
2. Use of Update method is required and hence requires multiple checks
3. Thorough testing is needed to acheive required results

## Project Setting used
1. Unity 2019.4.5f1
2. VS Code for C#
