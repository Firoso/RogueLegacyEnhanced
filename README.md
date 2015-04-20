# Rogue Legacy Enhanced

This project is supposed to add modability and fetatures to the original game engine.

This product is licensed under GPLv3. It is not maintained by any of the original creators and the original source this is being built on is not my own work! Therefore, all additional copyright notices of Cellar Doors Inc. applies, including not using this source for commercial use and re-releasing it with game files (dlls, assets, etc.)

In current state, it is just raw and bit fixed disassembly. It is compilable and launchable, but definitely not playable right now.

I started cleaning it up. After cleanup, I have in plan to fix most critical bugs in game's code, etc. After all these procedures, I'll start expanding the project with modability and features. 

To make it work, copy these files from game folder to lib folder:
* DS2DEngine.dll
* InputSystem.dll
* SpriteSystem.dll
* Tweener.dll

If you want to be able to use JIT, you must copy all other game data (including other dlls) into Release and Debug folders after first compilation.

Feel free to contribute to this project :)

##TO DO LIST:
###GENERAL CODE CLEANUP
###FIX ISSUES FOUND IN CLASSES:
* BossRoomType
* ClassType
* DiaryFlashBackScreen
* EndingRoomObj
* EnemyEV
* EnemyType
* GameEV
* GetItemType
* InputMapType
* LevelBuilder2
* LevelParser
* LightArea
* OrbType
* PlayerEV
* Program
* SkillBuilder
* SkillUnlockType
* SpecialItemType
* SpellEV
* SpellType
* TraitStatType
* VirtualScreen
