using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass16 {
    public class Solider : Character
    {
        public Solider() : base() {

        }
        public Solider(string name, Position posii, int health) : base(name, posii, health) {
            
            
        }
        public override void DisplayInfo () {
            Debug.Log("solider");
        }
    }
}