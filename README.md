# GemDrop

In this game, the user must catch as many gems as possible. In some cases, there may be "bad" gems that the user must avoid. This game uses animations to make the gems rotate while falling. Additionally, animations exist when the user finally catches a gem. 

This code consists of two Unity scripts: `PaddleScript` and `RandomDrop`. Here's a detailed description of what each script does:

### PaddleScript

1. **Purpose**: Controls the movement of a paddle object in a 2D space, likely for a game like Pong or Breakout.
2. **Start Method**: Currently empty and not used.
3. **Update Method**:
   - This method is called once per frame.
   - **Right Arrow Key**: When the right arrow key is pressed, the script checks if the paddle's x-position is less than 8. If true, it moves the paddle to the right.
   - **Left Arrow Key**: When the left arrow key is pressed, the script checks if the paddle's x-position is greater than -8. If true, it moves the paddle to the left.
   - The paddle moves at a speed of 4 units per second, controlled by `Time.deltaTime` to ensure smooth movement.

### RandomDrop

1. **Purpose**: Manages the random spawning of gem objects and handles their collision events.
2. **Variables**:
   - `gem`: A prefab for the gem object to be instantiated.
   - `gemList`: A list to store instantiated gem objects.
   - `text`: A `TextMeshProUGUI` component for displaying game over text.
   - `canvas`: The canvas object where the text will be displayed.
   - `count`: A counter to keep track of the number of collisions.
3. **Start Method**:
   - Initializes the `text` variable by adding a `TextMeshProUGUI` component to the `canvas` object.
4. **Update Method**:
   - Called once per frame.
   - Generates a random value between 0 and 600.
   - If the `count` is less than 10:
     - Checks if the random value is 4, then spawns a new gem at a random position along the x-axis at the top of the screen.
     - Adds the new gem to `gemList`.
     - Iterates through `gemList` to check for collisions and calls the `OnCollisionEnter` method for each gem.
   - If the `count` is 10 or more:
     - Clears the `gemList`.
     - Displays "Game Over -- Press Space to Quit" on the screen.
     - If the space key is pressed, stops the game (only works in the Unity Editor).
5. **OnCollisionEnter Method**:
   - Increases the `count` by one.
   - Destroys the gem object at the specified index in `gemList`.
   - Removes the gem from `gemList`.

### Additional Class (Gem)

1. **Purpose**: Seems intended to handle gem-related functionality, but the code is not fully integrated or utilized correctly.
2. **Constructor**: Attempts to initialize a new `GameObject` for the gem, but this logic is not correctly implemented.
3. **OnCollisionEnter Method**: Contains similar functionality to the `OnCollisionEnter` method in `RandomDrop`, but it's not properly integrated.

### Summary

- **PaddleScript**: Manages paddle movement based on arrow key inputs.
- **RandomDrop**: Handles random gem spawning, collision detection, and game over conditions, including UI updates.
- The `Gem` class is not fully implemented or integrated, indicating potential incomplete or redundant code.
