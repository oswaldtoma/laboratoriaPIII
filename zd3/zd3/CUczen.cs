using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace zd3
{
    public class CUczen
    {
        private string first_name, last_name;

        public CUczen(string firstName, string lastName)
        {
            first_name = firstName;
            last_name = lastName;
        }
        
        List<COcena> grades = new List<COcena>();
        
        public List<COcena> Oceny
        {
            get => grades;
            set => grades = value;
        }
        
        public void wystawOcene(string subjectName, double grade, ushort weight)
        {
            COcena tempOcena = new COcena();
            tempOcena.subject_name = subjectName;
            tempOcena.grade = grade;
            tempOcena.weight = weight;
            
            this.Oceny.Add(tempOcena);
        }

        public double sredniaWazona()
        {
            double weightedAverage = 0;
            ushort weightSum = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                weightedAverage += grades[i].grade * grades[i].weight;
                weightSum += grades[i].weight;
            }

            return weightedAverage / weightSum;
        }
    }
}