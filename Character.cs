using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass16 {
    public class Character 
    {
        protected string name;
        protected Position posii;
        protected int health;
        
        public Character(string name , Position position, int health) {
            this.name = name;
            this.posii = position; 
            this.Health = health;
        }
        public Character() : this("no name", new Position(0f, 0f, 0f), 100) {

        }
        public string Name{
            get{return name;}
            set{name = value;}
        }

        public Position Posii {
            get {return posii;}
            set {posii = value;}
        }
        
        public int Health {
            get {return health;}
            set {
                if(value > 100) {
                    health = 100;
                } else if(value < 0) {
                    value = 0;
                } else {
                    health = value;
                }

            }
        }
        public virtual void DisplayInfo() {
            Debug.Log("the name is :" + this.name);
            Debug.Log("the positoin is :" + this.posii.X + " " + this.posii.Y + " " + this.posii.Z);
            Debug.Log("the health is :" + this.health);
        }

        public void Attack(int damage, Character target) { 
            target.Health = -damage;
        }
        public void Attack(int damage, Character target, string attackType) {
            this.Attack(damage, target);
            Debug.Log(attackType);
        }

    }
}