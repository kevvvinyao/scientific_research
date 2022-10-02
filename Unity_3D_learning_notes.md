> *This markdown file is to record some Unity 3D knowledge.
More for this scientific research project, excluding fundamental knowledge.
We only discuss practical operation.*

# Component
`Component` is a significant and basic element in `Unity 3D`

As we know, we can create an `cube`, `capsule`, and other object with a shape

And we can also change their `texture` and color if we want. It is very easy to understand: `color` `texture` are attribute ---- we say `component` ---- of those `object`

But what you may not know is: the `shape` of object is also a `component` of them, which can be customized and can be changed, even can be removed

To verify above statement, we can create an **empty object**， which has no `component`.
Then we create a `cube`. Open the `component` panel, we can find that the `cube` has 1 more `component` than **empty object**. This implies that the 1 more `component` contribute to the shape of `cube` 

Then we **copy** that `component` from `cube` to **empty object**, we can surprisedly find out that: *The EMPTY OBJECT becomes a cubeEEEEEE!*


