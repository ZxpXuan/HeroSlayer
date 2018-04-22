﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    class PlayerActionAndValue
    {
        enum PlayerAction { };
        int value;   //如果枚举类型是技能，则值代表了该英雄的第几技能
    }

    class EnableEffectTypeValue      //这就是技能生效条件判定
    {
        enum EnableEffectTypes { camp,isSlowed,isStun,isRepeatedByStep,isHPLowerThan4 };
        bool value;
    }

    class BuffEffectAndValue
    {
        public enum SkillEffectTypes{}; //技能效果类型枚举 
        public float affectValue; //buff改变的属性值
    }

    enum SkillEffectTypes { HP,AP,stun,movingPoint,distance,createBuffOnTarget } // 存储技能效果类型枚举，用于“光克暗，庇护克物攻”之类的东西 ，这将用于技能效果的具体判定逻辑中
    enum EnableEffectTypes { camp,isSlowed,isStun,isRepeatedByStep,isHPLowerThan4 };  
    
    /*生效条件类型枚举
     isRepeatedByStep; buff效果是否按步骤再次发动，用于会产生持续性效果的技能，比如火海。如果不再次发动，
     则是在整个buff允许被触发的期间内，任意单位进出此区域只会被触发一次效果。注意，如果此时buff效果是立即的，则没有意义*/

    enum SkillTriggerType { isTheFirstOneTriggerThenDispear,isTheGeneralTrigger }

    /*isTheFirstOneTriggerThenDispear; 如果勾选，表示只要有角色进入trigger就会导致此trigger在下一步骤消失
    isTheGeneralTrigger; 若勾选，表示任何进入此触发区域的单位都会被施加buff*/

    enum Direction { up,down,left,right };//  技能释放时英雄的朝向
    enum PlayerAction { moving,skill }  // 玩家添加行动的行动类型


}