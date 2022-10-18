# scientific_research
This repository is for saving infomation and coding during the process of Scientific  Research Class ---- Mars Surface

# Week 0
> This part is in pinciple created before this project, but actually it is created in Week 3.

The title of this project is "Mars Surface Reconstruction", which is to use UAV to take pictures of Mars' surface and reconstruct its feature.

We is responsible for the Unity part, using Unity 3D to take photos and transform it to grayscale image, including generate its depth data.

# Week 1
## Content in class
Visit the lab. Introduced about the 4 different parts.

We should find out which part we are interested in and choose one to make further exploration.

## Achievement during current week
**Since the Class Time changes**, there are only two days between two adjacent lesson. So I didn't complete the task ---- Do investigation about four aspects.

Not so bad, Teacher L.L. decided to let us know those aspects in class.

# Week 2

## Content in class
Watch the display of senior using `Unity 3D` and `C#` to control the camera and take pictures to analyze their depth data.

This is powered by two `C#` scripts.
One is resiponsible for `Camera's movement`, and another is for `taking picture`.
Both they two make up the final result  

Then we choose **this direction (Unity 3D ---- data acquisiton)** because it is easier than other parts, but its workload may be quite heavy. (perhaps ten thousands of images)

The primary task is to learn Unity 3D and C#, look for some Mars Terrain Unity package, try obtain images and depth data.


### *EXTRA INFO: change username of github to `kevvvinyao`*

## Achievement during current week
Find out the work process of function in `C#` script.

Use the `python` program with `opencv` to handle the images taken before.

Transform them to depth data `.txt` and grayscale images `.png`.

More details and content of our achievements: see in `Unity_3D_learning_notes`

# Week 3

## Content in class

This week, two seniors display their achievement: using `python` scripts to develop an app, which can control the **drone** to take picture along the movement path.

Then the program use some algorithm to restore the original images of terrain.
But problems are very common, such as the **drone** become overheated: What we can only do is stop working and wait it to cool.

The ideal terrain should have characteristic appearance, such as stones, holes, so that it is easy and accurate to extract feature, register images, so-called `images alignment`

## Achievement during current week

Last week, we have completed the basic function: **Take pictures**, **transform grayscale** and **record depth**

What we should optimize:

1. Find a more complicated `Unity 3D` terrain.
To reflect the performance of our algorithm.
2. Record **height of camera**.
We take pictures with reducing height of camera, to analyze the `3D Model`.

Due to the new and strange language `C#` and software `Unity`, we do not complete above two optimization.

We have learned and analyze the exsiting `C#` code and `Unity` api, but we are so good at `C#` that we cannot use `class`, `method` skillfully.

About the **terrian**, we cannot find more complex source in *Taobao*.
They seems alike to each other.


# Week 4

## Content in class

Give an account of last week's achivement.

Since we haven't complete our tasks, there isn't so much result to display.

## Achivement during current week

We complete the basic function: Record the **Height** of camera.
But there are few `Unity` Mars terrain source accord with our demand.

We make a further exploration in `C#` and `Unity API`, write a function with `System.IO` to record **Height**, and add the data in an file of `.txt`

Besides the fundamental funtion of `Height recoding`, we also make an attempt to realize a **camera auto-move** function.
The main thinking: While pressing `BackSpace`, record the <u>**camera height**</u> and <u>**the most height of the terrain in the range of camera**</u>.
Then auto move the camera after each time take photo, and make sure that **camera** won't move under the terrain.

***However***, we do not complete this function as we imagine.
The problem is that camera don't move the ideal distance each time.
Its height only reduce several pixels each time.

***<u>We have completed the task!!!</u>***
Thanks to Mr.Niu, we implement the function of automatically move!!!
The reason why we failed before is that I misunderstand the meaning of worldpoint.z.
Now we can make step_length = (worldpoint.z)/10, so that the camera can conduct a reasonable movement.


# Week 5

## Content in class

We demonstrate our achievement ---- Automatically move and take images step by step.

Contact with senior, show our product.

## Achievement in current week

Get in touch with serveral seniors.

Receive more resource, such as `Blender` model.
Until then, what we search for is all `Unity Mars Model` instead of `Mars Model`.
So `Blender` model is a new *explorable* field, which maybe provide us with adequate Mars model.

Meanwhile, there will be a new problem to be solved ---- figure out a rational method to import the `fbx` (the file exported from Blender) to `Unity`.

*Additional*: `Blender` is more used for modeling than `Unity`,so we can search for Mars model in `Blender` or other softwares.
Then run our `C#` scripts in `Unity`.
It's called **specialization** (maybe







