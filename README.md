# Unity Playground Custom Scripts
A collection of custom scripts I wrote to expand the functionality of Unity Playground for my game design class.

<p xmlns:dct="http://purl.org/dc/terms/" xmlns:cc="http://creativecommons.org/ns#"><a rel="cc:attributionURL" property="dct:title" href="https://github.com/mrsimonsen/UnityPlaygroundCustomScripts">UnityPlaygroundCustomScripts</a> by <a rel="cc:attributionURL dct:creator" property="cc:attributionName" href="https://github.com/mrsimonsen">John Simonsen</a> is licensed under <a rel="license" href="https://creativecommons.org/licenses/by-nc/4.0?ref=chooser-v1" target="_blank" rel="license noopener noreferrer" style="display:inline-block;">CC BY-NC 4.0<img style="height:22px!important;margin-left:3px;vertical-align:text-bottom;" src="https://mirrors.creativecommons.org/presskit/icons/cc.svg?ref=chooser-v1"><img style="height:22px!important;margin-left:3px;vertical-align:text-bottom;" src="https://mirrors.creativecommons.org/presskit/icons/by.svg?ref=chooser-v1"><img style="height:22px!important;margin-left:3px;vertical-align:text-bottom;" src="https://mirrors.creativecommons.org/presskit/icons/nc.svg?ref=chooser-v1"></a></p>

## Current Script List
* [Animate When Button Press](#Button-Animate)
* [Condition 2 Key Press](#Condition-2-Key-Press)
* [Create On Death](#Create-On-Death)
* [Crouch Animated](#Crouch-Animated)
* [DayNight Timer](#DayNight-Timer)
* [Double Jump Animated](#Double-Jump-Animated)
* [Jump Animated](#Jump-Animated)
* [Level Generation](#Level-Generation-from-pixelmap)
* [Modify Health By Tag](#Modify-Health-By-Tag)
* [Move Animated](#Move-Animated)
* [Object Shooter 2 Keys](#Object-Shooter-2-Keys)

#### Task List
- [x] create object on death with more than 1 health
- [x] modify health by tag
- [x] 2 keys pressed at the same time to trigger action
- [x] ObjectShooter with 2 keys pressed
- [x] level generation from pixel map
- [x] avatar movement w/animation
- [x] avatar movement w/animation & constrained flip
- [x] avatar jump w/ animation
- [x] avatar double jump w/animation
- [x] Day/Night timer
- [x] Crouch animation
- [x] Button Press animation
- [ ] avatar attack w/ animation (range)
- [ ] bullet object animation
- [ ] avatar attack w/ animation (melee)
- [ ] fix object shooter to match rotation of both sides
- [ ] number of points loads a new level (instead of winning)
- [ ] mouse click to move
- [ ] mouse position to control player rotation
- [ ] figure out why CreateOnDeath doesn't work with animated sprites
- [ ] random time enemy spawner

## Script Explanations

### Button Animate
Extends the Condition Key Press to allow it to also trigger an animation.

### Condition 2 Key Press
Allows setting an action that happens when two keys are pressed at the same time.

### Create On Death
Allows an object to create a prefab when it's health reaches 0. Requires a Health System Attribute. This fixes the problem where an object will either create a prefab every time it's hit or being destroyed after 1 hit while having more health.

## Crouch Animated
Creates the ability to crouch with an animation.

## DayNight Timer
Sets a transparent black overlay on the scene with a timer to be day or night. You'll need to create an Empty Game Object in your scene and add this script to it. You will also need to add a Canvas component and set the Render Mode to "Screen Space - Overlay". Lastly, add an Image component and drag it into the Image box of the DayNight script.

## Double Jump Animated
Extents the "Jump" script to allow for double jumps with animation.

### Jump Animated
Extends the "Jump" script to allow it to trigger an animation.

### Level Generation from pixelmap
Generates prefabs based on pixel color from a colormap in a PNG or photoshop file. See tutorial video to see how it works.

### Modify Health By Tag
Allows an object to only do damage to a certain tag. This fixes the problem where bullets shot by the player damage the player or enemies damage other enemies.

### Move animated
Extends the "Move with arrows" script to allow it to trigger an animation. Also allows an avatar to be constrained in it's 'look direction'.

### Object Shooter 2 Keys
Allows you to shoot an object when 2 keys are pressed at the same time.
