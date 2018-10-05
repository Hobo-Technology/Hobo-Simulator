using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Character
{
    int hpOut;              //外伤健康值
    int hpIn;               //内伤健康值
    int hpMental;           //精神健康值

    int defOut;             //物理抗性
    int defIn;              //毒素抗性
    int mood;               //心情值（枚举类型）

    int corporeity;         //体质
    int cleanliness;        //卫生程度
    int coldResistance;     //寒冷抗性
    int hotResistance;      //炎热抗性

    int money;              //金钱（元角分）
    int commercialTalent;   //能力：商业才华
    int artisticTalent;     //能力：艺术才华
    int actingTalent;       //能力：表演才华
    int eloquence;          //能力：口才

    int strength;           //力量
    int agility;            //敏捷
    int intelligence;       //智力
    int moveSpeed;          //移动速度

    int lazyness;           //懒惰程度
    int exhaustion;         //疲惫值

    Character()
    {
        
    }
}
