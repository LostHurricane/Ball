using System;
using UnityEngine;
using System.Collections.Generic;


namespace GeekProject
{

    [Serializable]
    public sealed class SavedData
    {
        public Vector3Serializable PlayerPosition;
        public QuaternionSerializable LevelRotation;
        //public Vector3Serializable LevelRotation;

        //public List<Vector3Serializable> Traps;
        //public List<Vector3Serializable> Bonuses;

        public bool IsEnabled;
                
        public override string ToString() =>
            $"<color=red>Player</color> <color=red>Position</color> {PlayerPosition} <color=red>Rotation</color> {LevelRotation} <color=red>IsVisible</color> {IsEnabled}";
    }

    [Serializable]
    public struct Vector3Serializable
    {
        public float X;
        public float Y;
        public float Z;

        private Vector3Serializable(float valueX, float valueY, float valueZ)
        {
            X = valueX;
            Y = valueY;
            Z = valueZ;
        }

        public static implicit operator Vector3(Vector3Serializable value)
        {
            return new Vector3(value.X, value.Y, value.Z);
        }

        public static implicit operator Vector3Serializable(Vector3 value)
        {
            return new Vector3Serializable(value.x, value.y, value.z);
        }

        public override string ToString() => $" (X = {X} Y = {Y} Z = {Z})";
    }


    [Serializable]
    public struct QuaternionSerializable
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        private QuaternionSerializable(float valueX, float valueY, float valueZ, float valueW)
        {
            X = valueX;
            Y = valueY;
            Z = valueZ;
            W = valueW;
        }

        public static implicit operator Quaternion(QuaternionSerializable value)
        {
            return new Quaternion(value.X, value.Y, value.Z, value.W);
        }

        public static implicit operator QuaternionSerializable(Quaternion value)
        {
            return new QuaternionSerializable(value.x, value.y, value.z, value.w);
        }

        //public static implicit operator Quaternion(QuaternionSerializable value)
        //{
        //    return Quaternion.Euler(value.X, value.Y, value.Z);
        //}

        //public static implicit operator QuaternionSerializable(Quaternion value)
        //{
        //    return new QuaternionSerializable(value.eulerAngles.x, value.eulerAngles.y, value.eulerAngles.z);
        //}




        public override string ToString() => $" (X = {X} Y = {Y} Z = {Z} W = {Z}";
    }

}