using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass16 {
    public struct Position 
    {
        private float x;
        private float y;
        private float z;
     
        public Position(float x, float y, float z){
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float X{
            get {
                return x;
            }
            set  {
                this.x = value;
            }
        }
        public float Y {
            get {
                return this.y;
            }
            set {
                this.y = value;
            }
        }
        public float Z {
            get {
                return z;
            }
            set {
                this.z = value;
            }
        }
        public void printPosii() {
            Debug.Log(this.x + " " + this.y+ " " + this.z);
        }
    }
}
