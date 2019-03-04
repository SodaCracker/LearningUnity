# Modular
## Systems not directly dependent on each other
## Scenes are clean slates
### have no transient data that exists between scenes
### every time you hit a scene, it's a clean load.
### Scene.name != Menu.scene 不要有这种情况
## Prefabs work on their own
### Scene 是独立 prefabs 的集合
### 每个 prefab 又有独立功能
## Components!
# Editable
## Focus on data
### 系统和数据相独立，建立处理数据的系统
## Change the game without code
## Emergent design
### 设计好原理后，新的机制可以自然涌现
## Change at runtime
# Debuggable
## Test in isolation(modularity)
## Debug views and features
## Never fix a bug you do not understand
