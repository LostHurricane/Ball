using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekProject
{
    internal sealed class GameInitialisaton
    {
        public GameInitialisaton (Controllers controllers, Data data)
        {
            var inputInitialization = new InputInitialization();
            var TrapsAndBonuses = new TrapAndBonusInitializer(data);
            //controllers.Add (new CameraController(GameObject.Find("Player").transform, )
            controllers.Add(new InputController(inputInitialization.GetInput()));
            controllers.Add(new LevelRotator(inputInitialization.GetInput()));
        }

    }
}