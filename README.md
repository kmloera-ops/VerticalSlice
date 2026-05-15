# GDIM33 Vertical Slice
## Milestone 1 Devlog
1. The movement script graph first detects whenever an input action is pressed such as WASD. Then depending on the key pressed it will be multiplied by moveSpeed and Deltatime. Then this new variable will have its x and y received and x will be multiplied by getRight and y multiplied by getForward. Then the final vector 3 x value and vector 3 y value will be added together and then plugged into character controller move to move the player in the direction the player presses.
2. <img width="1275" height="743" alt="GDIM 33 Breakdown" src="https://github.com/user-attachments/assets/cfa5a8e2-afa3-452d-8528-9e18003ca553" />
  What I updated inside of my devlog was that I added the state machine to control whether the game was playable and lose and win state. Right now these graph has both things I want to achieve but right now that statemachine is what I currently have in my project. So right now when it detects that the time has ended it will trigger a win which will set the text to say "YOU WIN". Then if the monster reaches the player and catches them it will set the text to say "YOU LOSE". But something that they both do is set the isGameOver variable to true. Which in doing so makes the timer stop updating so it will stay on a win or lose screen. Then what it also does is that then isGameOver is true it will also stop all player and monster movement. This helps in signifying that the game is over. The way that currently playing transitions to either is if the monster script triggers the lose after colliding with the player or the game manager detects that the time has reached zero triggering the win.
  Now how this relates to other systems inside of my game is that right now it helps with stopping the game play and detecting when the game is done. But in the future I want this also later to include difficulty get higher so that overtime the monster will get harder and harder. This way it will make the monster move faster, make lights take longer to get fixed, and to start cutscenes of the player being defeated by the monster. But for now this provides an easy way to differentiate between the win and loss state. Since I am going to focus on doing cutscenes the statemachine will also help me in controlling when the player is in a moveable playable state, whether they are looking at their tablet, or if the monster has caught them. In doing so I want the tablet focus to cut all movement and free the mouse from being invisible and centered and then be transitionable back to playing and movement. Then when the monster catches up to the player I want a cutscene to play of the monster catching and destroying the player.


## Milestone 2 Devlog
### Question 1:
1. Create a light
    a. Create the lights in unity
    b. Arrange them around specific places around the map
     c.Give them a collider
2. Make it so the lights repel the monster
    a. Set up monster collision with the light
    b. Set up navmesh to send the monster in the opposite direction of the light
    c. Turn off that navmesh when the monster leaves it
3. Make the lights controllable by the player
    a. Create a button that can turn on all the lights
    b. Create a timer so that after a certain amount of seconds they turn off
4. Create a tablet UI
    a. Create a tablet UI that can pull up after the player presses E
    b. After pulling up the UI it will stop player movement and unlock mouse movement while keeping the player in the same space but allow them to move the mouse around to interact with the tablet.
5. Connect the tablet UI to the lights
    a. Have the lights appear as on and off button on the tablet so that the player can turn them on and off
    b. Show which lights are off and which lights are on
    c. Send a signal from the tablet to turn on a specific light.

### Question 2:
I do believe that it helped me build my feature for this milestone because it allowed me to not overcomplicate what was going on in my head and set mini goals for myself. This really helped me keep myself accountable in the times of when I really do not want to do work. Before when I used to do activities like this I wasn’t really sure if it was helping because it felt like I didn’t know enough to plan ahead. But now that I know more about programming and the game engine I feel like I am able to create better task steps. What I would do to improve my breakdowns I think is to add more technical terms and where I would do the task. I also would create a long recording because it would be nice to keep track of where everything is on a central doc.

### Question 3:
<img width="1405" height="600" alt="0" src="https://github.com/user-attachments/assets/aa221bdc-2855-4855-886b-5d3c1ccf855b" />
<img width="303" height="650" alt="0" src="https://github.com/user-attachments/assets/d5d06e85-22d8-4a31-a152-9e3790d23428" />

I would say that the way I bridged visual scripting and code inside of my game is through the use of my LightController script as it was going to be too messy to create it in visual scripting so I coded it and created the methods I needed to run the UI. In the first screenshot it shows a picture of my monster chase visual scripting graph and there I use the get component node to get access to the lightcontroller script to find out if the light that the monster is near is on or off. If it is on then it runs new code that will make it run away from the light. Then inside of the buttons for my tablet I was able to use the LightController script to call the method that turns on the lights and sets my isOn variable active which interacts with my monster script graph.

### Question 4:
The Unity system that I used for my game is Navmesh and inside my project I use navmesh for the monster to track the player and move towards them but I also use it to move it away from the lights when they are on. If the monster is not colliding with a light or the light is off the navmesh destination is the player, but if it is colliding with an on light then the new navmesh destination is (current position(monster) - light position) times lightRepel variable which makes the monster run to a different location outside of the light.


## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
