A simple Day/Night cycle system for Unity game engine.

[![Watch the video](https://img.youtube.com/vi/mlQhDlsiync/0.jpg)](https://www.youtube.com/watch?v=mlQhDlsiync)

Features
* You can set how many minutes the day last in real time. Select Assets->DayNightCycle->TimeSettings file and change variables to your liking.
* You can track every hour, sunset and sunrise from TimeService with subscribing the event.
* Sample scene is included with Pure Poly's Free Low Poly Nature Pack.
* Skybox is changing with day-Night cycle too. Also it is rotating on slow speed. You can change this settings on material.
* You can change the intensity settings from TimeManager object in prefab.

How to setup?
1. Delete directional light from your scene
2. Add DayNightCycle Prefab to your scene. Assets->DayNightCycle->Prefabs->
3. Go to Windows->Rendering->Lightning->Enviroment
4. Assign Sun source from DayNightCycle prefab on the scene
5. Assign Skybox material from  Assets->DayNightCycle->Materials->DayNightSkybox
6. Select camera on the Scene and activate Post Processing

