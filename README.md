# Unity Playground Custom Scripts
A collection of custom scripts I wrote to expand the functionality of Unity Playground for my game design class.

## Current Script List
* [Condition 2 Key Press](#Condition-2-Key-Press)
* [Create On Death](#Create-On-Death)
* [Modify Health By Tag](#Modify-Health-By-Tag)

#### Task List
- [x] create object on death with more than 1 health
- [x] modify health by tag
- [x] 2 keys pressed at the same time to trigger action
- [ ] number of points loads a new level (instead of winning)
- [ ] mouse click to move
- [ ] mouse position to control player rotation

## Script Explanations

### Condition 2 Key Press
Allows setting an action that happens when two keys are pressed at the same time.

### Create On Death
Allows an object to create a prefab when it's health reaches 0. Requires a Health System Attribute. This fixes the problem where an object will either create a prefab every time it's hit or being destroyed after 1 hit while having more health.

### Modify Health By Tag
Allows an object to only do damage to a certain tag. This fixes the problem where bullets shot by the player damage the player or enemies damage other enemies.
