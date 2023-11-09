# Unity Project Documentation

## Project Overview

- **Project Name**: Softura Bonus Task
- **Unity Version**: 2022.3.7f1

## Table of Contents

1. [Task Overview](#task-overview)
2. [Scenes](#scenes)
3. [Build Settings](#build-settings)
4. [Conclusion](#Conclusion)

## Task Overview
Create a Unity scene with a basic VR environment (e.g., a room) and implement a feature that allows the user to pick up and move objects within the scene using VR controllers. Provide the C# script and a brief description of the components used.
## Scenes

List the scenes in your Unity project.

### MainScene.unity

- The scene were setup with the XR interaction manager and assigned the left and right oculus controller.
- Added the direct interact and sphere collider for the left- and right-hand controller GameObjects.
- Added components like continues turn provider, continues move provider, char controller and char controller driver.
- Integrated the VR hand prefabs to relevant hand controllers as a child. These hands will animate to controller trigger and grab input interactions.
- Created player tag and mapped it to XR origin GameObject.Created intractable tag and mapped it to the intractable 3d models.

- Interactable Objects: Baseball Bat, Tennis bat, Tennis ball and Baseball.

- Use the Grab button in the controller to grab the objects.



## Build Settings

- **Platform**: Android
- **Resolution**: target resolution (e.g., 1920x1080)
- **Orientation**: Landscape
- **Graphics**: OpenGLES3
- **Scripting Background**: IL2CPP
- **Target Architecture**: ARM64
- **Minimum API Level**: Android 10


## Conclusion

I have completed the given task and have uploaded it here. Please do check it out. If you have any queries or feedbacks please do reach out at  <a href="mailto:francisarul.work@gmail.com?">francisarul.work@gmail.com</a>
