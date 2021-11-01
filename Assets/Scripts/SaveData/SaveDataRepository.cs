using System.Data;
using System.IO;
using UnityEngine;


namespace GeekProject
{
    public class SaveDataRepository : ISaveDataRepository
    {

        private readonly IData<SavedData> _data;

        private const string _folderName = "dataSave";
        private const string _fileName = "data.bat";
        private readonly string _path;

        //Vector3[] _traps;
        //Vector3[] _bonuses;

        public SaveDataRepository(/*Vector3[] traps, Vector3[] bonuses*/)
        {
            _path = Path.Combine(Application.dataPath, _folderName);
            //_traps = traps;
            //_bonuses = bonuses;
            _data = new SaverXML<SavedData>();
        }

        public void Save(Transform player, Transform levelRotation)
        {
            
            if (!Directory.Exists(Path.Combine(_path)))
            {
                Directory.CreateDirectory(_path);
            }

            var savePlayer = new SavedData
            {
                PlayerPosition = player.localPosition,
                LevelRotation = levelRotation.rotation,
                //LevelRotation = levelRotation.rotation.eulerAngles,
                IsEnabled = true,
              
            };
            Debug.Log("Save created: " + savePlayer.ToString());

            _data.Save(savePlayer, Path.Combine(_path, _fileName));
            
        }

        public void Load(Transform player, Transform levelRotation)
        {
            var file = Path.Combine(_path, _fileName);
            if (!File.Exists(file))
            {
                throw new DataException($"File {file} not found");
            }
            var newPlayer = _data.Load(file);
            player.localPosition = newPlayer.PlayerPosition;
            //levelRotation.rotation.eulerAngles.Set(newPlayer.LevelRotation.X, newPlayer.LevelRotation.Y, newPlayer.LevelRotation.Z);
            levelRotation.rotation = newPlayer.LevelRotation;

            player.gameObject.SetActive(newPlayer.IsEnabled);
            Debug.Log(newPlayer);
        }
    }
}