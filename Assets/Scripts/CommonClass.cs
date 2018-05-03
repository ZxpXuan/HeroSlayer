﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public class PlayerActionAndValue
    {
        public PlayerAction playerAction;
        public int value;   //如果枚举类型是技能，则值代表了该英雄的第几技能
    }

    [System.Serializable]
    public class EnableEffectTypeValue      //这就是技能生效条件判定
    {
        public EnableEffectTypes enbleEffectTypes;
        public int value;
    }
    [System.Serializable]
    public class BuffEffectAndValue
    {
        public SkillEffectTypes skillEffectTypes; //技能效果类型枚举 
        public int affectValue; //buff改变的属性值        以正负值表现加减
    }
    [System.Serializable]
    public class EnableTriggerEffectTypesAndValue
    {
        public SkillEffectTypes enableTriggerEffectTypes; //允许trigger条件判断类型枚举 ，类似buff生效枚举
        public int Value; //每一种类型对应的需求值
    }

    public enum SkillEffectTypes { HP, HP_Max, AP,AP_Max, stun,silence,movingPoint,movingPoing_Max,distance,createBuffOnTarget } // 存储技能效果类型枚举，这将用于技能效果的具体判定逻辑中
    public enum EnableEffectTypes { camp_opponent,camp_self, isSlowed_false, isSlowed_ture, isStun_ture, isStun_false,isHPLowerThan4_ture, isHPLowerThan4_false};  //这个需要在Buff生效和trigger生效时进行判定

    /*生效条件类型枚举
     isRepeatedByStep; buff效果是否按步骤再次发动，用于会产生持续性效果的技能，比如火海。如果不再次发动，
     则是在整个buff允许被触发的期间内，任意单位进出此区域只会被触发一次效果。注意，如果此时buff效果是立即的，则没有意义*/

    public enum SkillTriggerType { isTheFirstOneTriggerThenDispear, isRepeatedByStep }

    /* 1.isTheFirstOneTriggerThenDispear; 如果勾选，表示只要有角色进入trigger就会导致此trigger在下一步骤消失
    isTheGeneralTrigger; 若勾选，表示任何进入此触发区域的单位都会被施加buff
    2.isTheGeneralTrigger；如果勾选，表示这是通过trigger的存在时间来控制的trigger*/

    public enum Direction { up,down,left,right };//  技能释放时英雄的朝向
    public enum PlayerAction { moving,skill }  // 玩家添加行动的行动类型

}
