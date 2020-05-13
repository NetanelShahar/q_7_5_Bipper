This game purpose is to find the target via beep sound(good beep for getting colser and bad beep for getting further).
when tou find the target you will hear a cheering sound.

Control:
By clicking on the keybord arrows(not long pressing).

In the update() method i used the Vector2.Distance to claculate the distance between the player to the target in every frame.
if the new distance is less than the old one we hear a good beep. If it is less so we hear a bad beep.
I used the collision to play the cheering sound when we hit the target.

Code: https://github.com/netanelbenis/q_7_5_Bipper/blob/master/Assets/Scripts/Move.cs
https://github.com/netanelbenis/q_7_5_Bipper/blob/master/Assets/Scripts/bipper.cs
https://github.com/netanelbenis/q_7_5_Bipper/blob/master/Assets/Scripts/onCollide.cs

Game: https://netanelbenis.itch.io/beeper
