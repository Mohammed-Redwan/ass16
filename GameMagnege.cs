using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass16 {
    public class GameMagnege : MonoBehaviour
    {

        void Start()
        {
            
            Character c = new Character();
            Solider s = new Solider("solider", new Position(23, 5, 6), 67);
            Officer o = new Officer();

            Character[] arrayOfChar = {c, s, o};
            for(int i = 0; i < arrayOfChar.Length; i++) {
                arrayOfChar[i].DisplayInfo();
            }




        }

    }
}