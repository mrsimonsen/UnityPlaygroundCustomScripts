# Unity Playground Custom Scripts
A collection of custom scripts I wrote to expand the functionality of Unity Playground for my game design class.

## Current Script List
* [Condition 2 Key Press](#Condition-2-Key-Press)
* [Create On Death](#Create-On-Death)
* [Modify Health By Tag](#Modify-Health-By-Tag)
* [Object Shooter 2 Keys](#Object-Shooter-2-Keys)
* [Level Generation](#Level-Generation-from-pixelmap)
* [Move Animated](#Move-Animated)
* [Jump Animated](#Jump-Animated)

#### Task List
- [x] create object on death with more than 1 health
- [x] modify health by tag
- [x] 2 keys pressed at the same time to trigger action
- [x] ObjectShooter with 2 keys pressed
- [x] level generation from pixel map
- [x] avatar movement w/animation
- [x] avatar movement w/animation & constrained flip
- [x] avatar jump w/ animation
- [ ] avatar attack w/ animation (range)
- [ ] avatar attack w/ animation (melee)
- [ ] fix object shooter to match rotation of both sides
- [ ] number of points loads a new level (instead of winning)
- [ ] mouse click to move
- [ ] mouse position to control player rotation
- [ ] figure out why CreateOnDeath doesn't work with animated sprites

## Script Explanations

### Condition 2 Key Press
Allows setting an action that happens when two keys are pressed at the same time.

### Create On Death
Allows an object to create a prefab when it's health reaches 0. Requires a Health System Attribute. This fixes the problem where an object will either create a prefab every time it's hit or being destroyed after 1 hit while having more health.

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
