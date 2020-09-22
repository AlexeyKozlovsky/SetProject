using SetProject.Models.Exceptions;
using System;
using System.Collections.Generic;

namespace SetProject.Models
{
    class SetField
    {
        public Set UniversalSet { get; private set; }
        private List<Set> sets;
        public Set this[int index]
        {
            get { return this.sets[index]; }
            set { this.sets[index] = value; }
        }

        public int Sets { get { return this.sets.Count; } }

        public SetField(Set universalSet)
        {
            this.UniversalSet = universalSet;
            this.sets = new List<Set>();
        }

        public void AddSet(Set set)
        {
            if (set < this.UniversalSet) this.sets.Add(set);
            else throw new SetFieldException();
        }

        public void RemoveSet(Set set)
        {
            if (this.sets.Contains(set)) this.sets.Remove(set);
        }

        private void SetNumCheck(int setNum)
        {
            if (setNum >= this.sets.Count || setNum < 0)
                throw new Exception();
        }

        private int[] GetCharacteristicVector(int setNumber)
        {
            SetNumCheck(setNumber);

            int[] result = new int[this.UniversalSet.Mod];
            int j = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (this.UniversalSet[i].Equals(this[setNumber][j]))
                {
                    result[i] = 1;
                    if (++j >= this[setNumber].Mod) return result;
                }
            }

            return result;
        }

        private Set GetSetFromCharacteristicVector(int[] vector)
        {
            List<object> setValues = new List<object>();
            for (int i = 0; i < vector.Length; i++)
                if (vector[i] != 0) setValues.Add(this.UniversalSet[i]);

            Set result = new Set(setValues);
            return result;
        }
            
        public Set Conjuction(int setNum1, int setNum2)
        {
            this.SetNumCheck(setNum1);
            this.SetNumCheck(setNum2);

            if (this[setNum1].IsEmpty || this[setNum2].IsEmpty)
                return new Set("");

            int[] setVector1 = this.GetCharacteristicVector(setNum1);
            int[] setVector2 = this.GetCharacteristicVector(setNum2);
            int[] resultVector = new int[this.UniversalSet.Mod];


            for (int i = 0; i < this.UniversalSet.Mod; i++)
                resultVector[i] = setVector1[i] * setVector2[i];

            return this.GetSetFromCharacteristicVector(resultVector);
        }

        public Set Disjunction(int setNum1, int setNum2)
        {
            this.SetNumCheck(setNum1);
            this.SetNumCheck(setNum2);

            if (this[setNum1].IsEmpty) return this[setNum2];
            if (this[setNum2].IsEmpty) return this[setNum1];

            int[] setVector1 = this.GetCharacteristicVector(setNum1);
            int[] setVector2 = this.GetCharacteristicVector(setNum2);
            int[] resultVector = new int[this.UniversalSet.Mod];


            for (int i = 0; i < this.UniversalSet.Mod; i++)
                resultVector[i] = setVector1[i] + setVector2[i];

            return this.GetSetFromCharacteristicVector(resultVector);
        }

        public Set ReverseSet(int setNum)
        {
            this.SetNumCheck(setNum);

            if (this[setNum].IsEmpty) return this.UniversalSet;

            int[] setVector = this.GetCharacteristicVector(setNum);

            for (int i = 0; i < this.UniversalSet.Mod; i++)
                setVector[i] = setVector[i] == 0 ? 1 : 0;

            return this.GetSetFromCharacteristicVector(setVector);
        }

        public string GetCharacteristicVectorString(int setNum)
        {
            string result = "{";
            int[] vector = this.GetCharacteristicVector(setNum);

            for (int i = 0; i < vector.Length; i++) result += $"{vector[i]}, ";

            result = result.Substring(0, result.Length - 2) + "}";
            return result;
        }
    }
}
