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
            controllers.Add(new PlayerProgressChecker(data.GetBonusData().WiningScore));
            controllers.Add(new InputController(inputInitialization.GetInputMovement(), inputInitialization.GetInputDataSave()));
            controllers.Add(new LevelRotator(inputInitialization.GetInputMovement()));
            controllers.Add(new SaveLoadManager(inputInitialization.GetInputDataSave(), player, level));


        }

    }
}