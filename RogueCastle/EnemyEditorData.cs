/*
  Rogue Legacy Enhanced

  This project is based on modified disassembly of Rogue Legacy's engine, with permission to do so by its creators.
  Therefore, former creators copyright notice applies to original disassembly. 

  Disassembled source Copyright(C) 2011-2015, Cellar Door Games Inc.
  Rogue Legacy(TM) is a trademark or registered trademark of Cellar Door Games Inc. All Rights Reserved.
*/

using Microsoft.Xna.Framework;

namespace RogueCastle
{
    public struct EnemyEditorData
    {
        public Vector2 AdvancedScale;
        public Vector2 BasicScale;
        public Vector2 ExpertScale;
        public Vector2 MinibossScale;
        public string SpriteName;
        public byte Type;

        public EnemyEditorData(byte enemyType)
        {
            var enemyObj = EnemyBuilder.BuildEnemy(enemyType, null, null, null, GameTypes.EnemyDifficulty.BASIC);
            var enemyObj2 = EnemyBuilder.BuildEnemy(enemyType, null, null, null, GameTypes.EnemyDifficulty.ADVANCED);
            var enemyObj3 = EnemyBuilder.BuildEnemy(enemyType, null, null, null, GameTypes.EnemyDifficulty.EXPERT);
            var enemyObj4 = EnemyBuilder.BuildEnemy(enemyType, null, null, null, GameTypes.EnemyDifficulty.MINIBOSS);
            Type = enemyType;
            SpriteName = enemyObj.SpriteName;
            BasicScale = enemyObj.Scale;
            AdvancedScale = enemyObj2.Scale;
            ExpertScale = enemyObj3.Scale;
            MinibossScale = enemyObj4.Scale;
        }
    }
}