# Plataforma 2D — Unity

Proyecto de plataformas 2D desarrollado con Unity **6000.6.3f1**.

## Abrir el proyecto

1. Clona este repositorio con Git y Git LFS instalados.
2. Ejecuta `git lfs pull` dentro de la carpeta del repositorio.
3. En Unity Hub, agrega la carpeta del repositorio y ábrela con Unity 6000.6.3f1.
4. Espera a que Unity restaure los paquetes e importe los assets.
5. Abre `Assets/Scenes/SampleScene.unity` y pulsa Play.

## Archivos incluidos

- `Assets/`: scripts, escenas, sprites, tiles, clips de animación, Animator Controller y sus archivos `.meta`.
- `Packages/`: dependencias y archivo de bloqueo de paquetes.
- `ProjectSettings/`: configuración y versión del proyecto.

Las animaciones y el controlador están en `Assets/Animations`; el código del jugador está en `Assets/Scripts/PlayerController.cs`.

El archivo `.gitignore` excluye carpetas generadas como `Library`, `Temp`, `Logs`, `Obj` y `UserSettings`. Unity las vuelve a generar al abrir el proyecto. Los archivos binarios seleccionados por `.gitattributes`, incluidas las imágenes, se almacenan mediante Git LFS.
