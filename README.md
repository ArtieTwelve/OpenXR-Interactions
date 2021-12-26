# Interaction Exerciser

### 12.26.21<br>

 I was able to get this all to work by setting up three seperate scenes. A single cube in each scene.
 * PlayerInputTest - uses the player input component and unity events
 * CodeControllerTest - uses a pure code solution to assign actions to events
 * ActionReferenceTest - uses serialized fields to assign Two Actions and one Action Reference in the inspector.

All of this is just firing simple cube color changes, but it's enough. Now I need more interactions.


### 12.24.21<br>

Finally got a button to work. Once I had that, I split the setup into three sections.

* PlayerInput component
* Action/References in the editor
* All Code - generating bindings programatically

This did not work as there is no way for me (for now) to differentiate between the three floating cubes via the controllers alone. Should have thought it through. Still, they are solid examples of three ways to hook up Actions. 


