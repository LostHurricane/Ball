using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

namespace GeekProject
{
    internal sealed class GameInitialisaton
    {
        public GameInitialisaton (Controllers controllers, Data data, Transform player, Transform level)
        {
            var inputInitialization = new InputInitialization(data.GetInputData());
            var TrapsAndBonuses = new TrapAndBonusInitializer(data);
            //controllers.Add (new CameraController(GameObject.Find("Player").transform, )
            controllers.Add(new InputController(inputInitialization.GetInputMovement(), inputInitialization.GetInputDataSave()));
            var levelTurner = new LevelRotator(inputInitialization.GetInputMovement());
            controllers.Add(levelTurner);
            controllers.Add(new SaveLoadManager(inputInitialization.GetInputDataSave(), player, level, (TrapsAndBonuses.GetTrapsCoordinates(), TrapsAndBonuses.GetBonusCoordinates()), levelTurner));


        }

    }
}