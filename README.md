<img width="852" height="477" alt="example" src="https://github.com/user-attachments/assets/20da8989-93ad-4655-b25c-c07fb9ace8f5" />
# GDIM33 Vertical Slice
## Milestone 1 Devlog
1. The movement script graph first detects whenever an input action is pressed such as WASD. Then depending on the key pressed it will be multiplied by moveSpeed and Deltatime. Then this new variable will have its x and y received and x will be multiplied by getRight and y multiplied by getForward. Then the final vector 3 x value and vector 3 y value will be added together and then plugged into character controller move to move the player in the direction the player presses.
2. <img width="1275" height="743" alt="GDIM 33 Breakdown" src="https://github.com/user-attachments/assets/cfa5a8e2-afa3-452d-8528-9e18003ca553" />
  What I updated inside of my devlog was that I added the state machine to control whether the game was playable and lose and win state. Right now these graph has both things I want to achieve but right now that statemachine is what I currently have in my project. So right now when it detects that the time has ended it will trigger a win which will set the text to say "YOU WIN". Then if the monster reaches the player and catches them it will set the text to say "YOU LOSE". But something that they both do is set the isGameOver variable to true. Which in doing so makes the timer stop updating so it will stay on a win or lose screen. Then what it also does is that then isGameOver is true it will also stop all player and monster movement. This helps in signifying that the game is over. The way that currently playing transitions to either is if the monster script triggers the lose after colliding with the player or the game manager detects that the time has reached zero triggering the win.
  Now how this relates to other systems inside of my game is that right now it helps with stopping the game play and detecting when the game is done. But in the future I want this also later to include difficulty get higher so that overtime the monster will get harder and harder. This way it will make the monster move faster, make lights take longer to get fixed, and to start cutscenes of the player being defeated by the monster. But for now this provides an easy way to differentiate between the win and loss state. Since I am going to focus on doing cutscenes the statemachine will also help me in controlling when the player is in a moveable playable state, whether they are looking at their tablet, or if the monster has caught them. In doing so I want the tablet focus to cut all movement and free the mouse from being invisible and centered and then be transitionable back to playing and movement. Then when the monster catches up to the player I want a cutscene to play of the monster catching and destroying the player.


## Milestone 2 Devlog
### Question 1:
1. Create a light
   1. Create the lights in unity
   2. Arrange them around specific places around the map
   3. Give them a collider
2. Make it so the lights repel the monster
     1. Set up monster collision with the light
     2. Set up navmesh to send the monster in the opposite direction of the light
     3. Turn off that navmesh when the monster leaves it
3. Make the lights controllable by the player
   1. Create a button that can turn on all the lights
   2. Create a timer so that after a certain amount of seconds they turn off
4. Create a tablet UI
   1. Create a tablet UI that can pull up after the player presses E
   2. After pulling up the UI it will stop player movement and unlock mouse movement while keeping the player in the same space but allow them to move the mouse around to interact with the tablet.
5. Connect the tablet UI to the lights
    1. Have the lights appear as on and off button on the tablet so that the player can turn them on and off
    2. Show which lights are off and which lights are on
    3. Send a signal from the tablet to turn on a specific light.

### Question 2:
I do believe that it helped me build my feature for this milestone because it allowed me to not overcomplicate what was going on in my head and set mini goals for myself. This really helped me keep myself accountable in the times of when I really do not want to do work. Before when I used to do activities like this I wasn’t really sure if it was helping because it felt like I didn’t know enough to plan ahead. But now that I know more about programming and the game engine I feel like I am able to create better task steps. What I would do to improve my breakdowns I think is to add more technical terms and where I would do the task. I also would create a long recording because it would be nice to keep track of where everything is on a central doc.

### Question 3:
<img width="1405" height="600" alt="0" src="https://github.com/user-attachments/assets/aa221bdc-2855-4855-886b-5d3c1ccf855b" />
<img width="303" height="650" alt="0" src="https://github.com/user-attachments/assets/d5d06e85-22d8-4a31-a152-9e3790d23428" />

I would say that the way I bridged visual scripting and code inside of my game is through the use of my LightController script as it was going to be too messy to create it in visual scripting so I coded it and created the methods I needed to run the UI. In the first screenshot it shows a picture of my monster chase visual scripting graph and there I use the get component node to get access to the lightcontroller script to find out if the light that the monster is near is on or off. If it is on then it runs new code that will make it run away from the light. Then inside of the buttons for my tablet I was able to use the LightController script to call the method that turns on the lights and sets my isOn variable active which interacts with my monster script graph.

### Question 4:
The Unity system that I used for my game is Navmesh and inside my project I use navmesh for the monster to track the player and move towards them but I also use it to move it away from the lights when they are on. If the monster is not colliding with a light or the light is off the navmesh destination is the player, but if it is colliding with an on light then the new navmesh destination is (current position(monster) - light position) times lightRepel variable which makes the monster run to a different location outside of the light.


## Milestone 3 Devlog
### Question 1:
The way that my shader graph works is that it uses time and multiply to create the flashing speed. If I were to decrease the x values it would flash slower and if I were to increase it then it would flash faster. This then outputs into a sine node which gives out values between -1 and 1. Though these numbers should just be between 0 and 1 so to do that I attached a remap node which converts the sine wave into a range from 0 to 1 rather than -1 to 1. Then with the Lerp node it is able to blend the colors together so when it receives a 0 from the remap node it turns the base color black and when it receives a 1 it turns the color to white. This lerp node is able to make a smooth transition between white and black. This is then connected to the base color input. This shader can be found on the monster model and found in the Shaders folder called Monster Shader.
<img width="1078" height="791" alt="Shader graph" src="https://github.com/user-attachments/assets/e098d05c-1208-407c-b235-bf0ac8d6b07a" />

### Question 2:
So what I changed to my game from the playtesting was that I created a new tablet UI that shows where the lights are on a map. This map shows where the player starts and where the lights are so that they can have an easier time controlling them. I fixed lag issues with the map so that players can play more smoothly since many were complaining about lag spikes. I also saw that players weren’t encouraged to find the exit and thought it would be easier to just wait out the monster so I completely removed the win condition of the timer. Instead I increased it to 2 minutes for the player to get out or they lose. At this second I have been trying to work on setting up audio for the monster to play when it is getting closer but right now I added a shader graph to the monster so that it is more noticeable when you look at it. Then the one of the biggest complaints that I fixed was I changed the mouse sensitivity to be lower so players do not have to be so careful when moving. So I believe the only playtesting feedback that I have not yet addressed was adding SFX so that players know when the monster is getting closer to them.

### Question 3:
Since the last milestone I have added a bit more. First I created more lights and expanded the map. Then in this new expanded map I created an exit for the player to be able to find to escape. With this new exit I have also changed the win condition of waiting out the timer to instead have the player have to reach the exit to win. I also created a map when the tablet is opened so that players can see where they start and where the lights are on the map. I also made the enemy look different while also adding shaders. Now not only does the monster flash white and black the map also looks slightly different. So all in all the objective of the game has changed to finding an exit instead of surviving this way the players have more encounters with the monster. Although there are a few issues which I will address in the future such as right now there is a bug with mouse controls where sometimes the camera will flick downwards and I will of course address adding audio cues at a later date.

## Milestone 4 Devlog
Milestone 4 Devlog goes here.



## Final Devlog
1. The current gameplay loop is that the player loads into a map where they need to roam and find the exit with a limited amount of time. During this time a monster is chasing them and is faster then them so just running won’t help. But what you have against the monster is that you can control the lights and the monster hates the lights so you can scare it off with them. What this is able to illustrate to my original plan of the vertical slice is the use of dread as a monster gets closer and closer in the dark and how the player feels a sense of reprieve when close to a light. Also not knowing where the exit makes the player feel a sense of dread as they are being chased and a timer is counting down.
2. The way that the rendering effect is activated from my gameplay logic is that inside of the monster visual scripting graph it is tracking how close the monster is to the player and once it gets below a certain threshold it then activates chase music. Then it also uses the Material: Set Float to change the variable _Intensity on my fullscreenshader graph material to  make the vignette I made visible on the player's screen. Then once the monster is a specific distance away then it turns off the chase music, and the graph sets the _Intensity value back to 0 which hides the vignette.
<img width="1427" height="817" alt="Shaders" src="https://github.com/user-attachments/assets/09771b39-fe10-4751-8d5f-ee1c3a4e4de3" />

<img width="852" height="477" alt="example" src="https://github.com/user-attachments/assets/c030253c-1fd0-43f5-97ad-74b2dc712dbf" />
this is what it is supposed to look like in the game but the itch build does not work for some reason

3. I did like using the bubble diagrams breakdowns but it became very difficult when I was trying to figure out how to do stuff. Trying to plan ahead about stuff I do not understand yet felt more crippling in my production than it helped. I would say that in the future as I gather more and more information bubble diagram breakdowns will be very useful. On the other hand I found the task step breakdowns extremely useful as it allowed me to take things I didn’t know much about into small attainable steps. I will definitely be using task step breakdowns in the future. I think by breaking down a large project into smaller steps it allows me to not overthink about how much work I need to complete in the long run and focus more on short goals. I am the type to get discouraged by lots of work so short term goals are very helpful to me. I believe that I had a good plan going into this project and it was that week by week I chose a specific mechanic I wanted to be done and by splitting these up I was able to learn how to create them without too much pressure from the rest of the game. I think by focusing on getting the basic gameplay loop down it allowed me to decide what I was doing was actually fun or not before investing more time into it. It also allowed me to quickly get to playtesting which helped a lot more than I thought. I think that the plan I followed this quarter went really well and for my first solo game it was really fun and I am really proud of the work I did. Although I really wish I could have spent more time making the game look nice I think I made something fun that people can play. I think in the future I will have more of a focus on other factors of the game like UI, Art, environment, etc. instead of just gameplay mechanics because I had a lot of players complain that it was hard to tell what was going on.


## Open-source assets
I made the music myself using bandlab
- Cite any external assets used here!
