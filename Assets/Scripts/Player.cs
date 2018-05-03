﻿using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player:MonoBehaviour
    {
        private int playerID;  //玩家ID，初版功能只需要用序号代替玩家就行了
        private Sprite playerIcon;  //玩家ICON
        public int actionPoint=8;  //当前AP点数 
        public int actionPoint_Max=8; //总AP点数 
        private List<GameObject> heroes; //用于存储单个玩家操控的英雄对象列表(所以这是个prefab)，当英雄死亡时需要重新维护
        private int Camp;//存储玩家的阵营
        private Castle castle; //存储玩家对应的基地

        private void Awake()
        {
            //添加玩家选择的英雄池
            
        }

        public void AddHeros(GameObject h)
        {
            heroes.Add(h);
        }
        public List<GameObject> GetHeroes()
        {
            return heroes;
        }

        public int GetAP_Max()
        {
            return actionPoint_Max;
        }
        public void SetAP_Max(int AP)
        {
            actionPoint_Max = AP;
        }
        public int GetAP_Cur()
        {
            return actionPoint;
        }
        public void SetAP_Cur(int AP)
        {
            actionPoint = AP;
        }


        public void SetCamp(int camp)
        {
            Camp = camp;
        }
        public int GetCamp()
        {
            return Camp;
        }

        public void SetICON(Sprite icon)
        {
            playerIcon = icon;
        }
        public Sprite GetICON()
        {
            return playerIcon;
        }

        public void SubtractCastleHP()
        {
            castle.SetCSHP_Curr (castle.GetCSHP_Cur() - castle.basicDMG);
        }
    }
}