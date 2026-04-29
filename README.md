# GDIM33 Vertical Slice
## Milestone 1 Devlog
1. The movement script graph first detects whenever an input action is pressed such as WASD. Then depending on the key pressed it will be multiplied by moveSpeed and Deltatime. Then this new variable will have its x and y received and x will be multiplied by getRight and y multiplied by getForward. Then the final vector 3 x value and vector 3 y value will be added together and then plugged into character controller move to move the player in the direction the player presses.
2. <img width="1275" height="743" alt="GDIM 33 Breakdown" src="https://github.com/user-attachments/assets/cfa5a8e2-afa3-452d-8528-9e18003ca553" />
  What I updated inside of my devlog was that I added the state machine to control whether the game was playable and lose and win state. Right now these graph has both things I want to achieve but right now that statemachine is what I currently have in my project. So right now when it detects that the time has ended it will trigger a win which will set the text to say "YOU WIN". Then if the monster reaches the player and catches them it will set the text to say "YOU LOSE". But something that they both do is set the isGameOver variable to true. Which in doing so makes the timer stop updating so it will stay on a win or lose screen. Then what it also does is that then isGameOver is true it will also stop all player and monster movement. This helps in signifying that the game is over. The way that currently playing transitions to either is if the monster script triggers the lose after colliding with the player or the game manager detects that the time has reached zero triggering the win.
  Now how this relates to other systems inside of my game is that right now it helps with stopping the game play and detecting when the game is done. But in the future I want this also later to include difficulty get higher so that overtime the monster will get harder and harder. This way it will make the monster move faster, make lights take longer to get fixed, and to start cutscenes of the player being defeated by the monster. But for now this provides an easy way to differentiate between the win and loss state. Since I am going to focus on doing cutscenes the statemachine will also help me in controlling when the player is in a moveable playable state, whether they are looking at their tablet, or if the monster has caught them. In doing so I want the tablet focus to cut all movement and free the mouse from being invisible and centered and then be transitionable back to playing and movement. Then when the monster catches up to the player I want a cutscene to play of the monster catching and destroying the player.


## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
