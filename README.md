# Rogue Legacy Enhanced

This project is supposed to add modability and fetatures to the original game engine.

This product is licensed under GPLv3. The source code is not maintained by any of the original creators and the original source this is being built on is not my own work! Therefore, all additional copyright notices of Cellar Doors Inc. applies, including not using this source for commercial use and re-releasing it with game files (dlls, assets, etc.)

In current state, it is just raw, cleaned and fixed disassembly. It is compilable, launchable and now even playable.

I currently finished cleaning it, so right now I'm focusing on fixing most critical bugs in engine's code, which currently prevents it to be playable. When all of these fixes are done, I can start expanding the project with modability and features. 

To make it work, copy these files from game folder to lib folder:
* DS2DEngine.dll
* InputSystem.dll
* SpriteSystem.dll
* Tweener.dll

If you want to be able to use JIT, you must copy all other game data (including other dlls) into Release and Debug folders after first compilation.

Feel free to contribute to this project :)

##TO DO LIST:
###1. CHECK FOR ERRORS
(basically some very long playing seasons from now on to find some more errors, if any...)
###2. WORK ON LOADING THINGS FROM EXTERNAL SOURCES
(work on the actual modability)
###3. TBA
