using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment4
{
    
    public class Arena
    {
        public uint Capacity { get; private set; }
        public string ArenaName { get; private set; }
        public uint Turns { get; private set; }
        public uint MonsterCount { get; private set; }
        public List<Monster> MonsterList { get; private set; }

        public Arena(string arenaName, uint capacity)
        {
            ArenaName = arenaName;
            Capacity = capacity;
        }
        
        public void LoadMonsters(string filePath)
        {
            List<Monster> monstersList = new List<Monster>();

            using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate))
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8, false))
            {
                while (!sr.EndOfStream)
                {
                    if (MonsterCount == Capacity)
                    {
                        break;
                    }
                    string s = sr.ReadLine();
                    string[] temp = s.Split(',');
                    var element = Enum.Parse(typeof(EElementType), temp[1]);
                    monstersList.Add(new Monster(temp[0], (EElementType)element, int.Parse(temp[2]), int.Parse(temp[3]), int.Parse(temp[4])));
                    MonsterCount++;
                }
            }
            MonsterList = monstersList;    
        }
        public void GoToNextTurn()
        {
            if (MonsterCount > 1)
            {
                for (int i = 0; i < MonsterCount; i++)
                {
                    int nextIndex = i + 1;
                    if (nextIndex > MonsterCount - 1)
                    {
                        nextIndex = 0;
                    }
                    MonsterList[i].Attack(MonsterList[nextIndex]);
                    if (MonsterList[nextIndex].Health <= 0)
                    {
                        MonsterList.Remove(MonsterList[nextIndex]);
                        MonsterCount--;
                    }
                }
                Turns++;
            }
        }
        public Monster GetHealthiest()
        {
            if (MonsterCount == 0)
            {
                return null;
            }
            if (MonsterCount == 1)
            {
                return MonsterList[0];
            }
            int healthiestMonsterIndex = -1;
            int health = int.MinValue;
            for (int i = 0; i < MonsterCount; i++)
            {
                if (MonsterList[i].Health > health)
                {
                    health = MonsterList[i].Health;
                    healthiestMonsterIndex = i;
                }
            }
            return MonsterList[healthiestMonsterIndex];
        }
    }
}
