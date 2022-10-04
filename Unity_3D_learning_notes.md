> *This markdown file is to record some Unity 3D knowledge.
More for this scientific research project, excluding fundamental knowledge.
We only discuss practical operation.*

# Component
`Component` is a significant and basic element in `Unity 3D`

### Process of Explore
As we know, we can create an `cube`, `capsule`, and other object with a shape

And we can also change their `texture` and color if we want. It is very easy to understand: `color` `texture` are attribute ---- we say `component` ---- of those `object`

But what you may not know is: the `shape` of object is also a `component` of them, which can be customized and can be changed, even can be removed

To verify above statement, we can create an **empty object**， which has no `component`.
Then we create a `cube`. Open the `component` panel, we can find that the `cube` has 1 more `component` than **empty object**. This implies that the `component` <u> _that `cube` has while **empty object** does not have_ </u> contributes to the shape of `cube` 

Then we **copy** that `component` from `cube` to **empty object**, we can surprisedly find out that: *The EMPTY OBJECT becomes a cubeEEEEEE!*

### Sum up and Extension
How an `object` performs, what color and texture it has, are **all** decided by `component`, which can be added, removed and changed by user if they want.

If we want a `cube1` to perform not as a cube any longer, we can immediately remove its `component` about its shape, and add another shape to it.
If we want an `object2` to fall automatically just like being affected by the gravity, we can search component of `rigid` and add it to the `object2`.

Actually, not only can such template `component` be added to any object, we can also create some `component` ourselves to let `object` have some feature that we want

To achieve that, we create `C#` scripts to endow an `object` some features.

# C# scripts

> Unity is a _game engine_

Just like some `2d game`, such as **stardew vally**, we can move the character by pressing keyboard: `W` `A` `S` `D`

This is a typical implement with `C# scripts`, which can control the characters and camera if you like

In our project, we use `C#` to control the movement of camera and take pictures of _Mars terrain_.
We needn't explore the complex principle and math knowledge behind the `C# scripts`, what we need to master is just using the provided function.

### start function
The content in `start() {}` will be excuted when we begin the "game". It runs only once.

### update function
The content in it will run every `frame`. In other words, if you want to give an object some features that can be called any time, you should write `C#` sentences in this part.

For example, movement of object should be written in the part, so that you can give it an order to move any frame


