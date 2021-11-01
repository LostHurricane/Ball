using UnityEngine;

namespace GeekProject
{
    public interface ISaveDataRepository
    {
        void Save(Transform player, Transform levelRotation);

        void Load(Transform player, Transform levelRotation);
    }
}