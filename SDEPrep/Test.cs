using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEPrep
{
    public class AWSTest
    {
        public AWSTest()
        {
            var combinationResult = ComputeCombination();
            var powerResult = PowerQuestion();
        }

        private int ComputeCombination()
        {
            //List<int> data = new List<int>() { 4, 20, 13, 8, 9 };
            List<int> data = new List<int>() { 2, 43, 5, 6, 10, 34 };
            //List<int> data = new List<int>() { 2, 9, 10, 3, 7 };
            return ComputeCombination(data);

            //List<int> results = new List<int>();
            //for (int i = 0; i < data.Count + 1; i++)
            //{
            //    var combination = new List<int>();
            //    data.ForEach(x => { combination.Add(x); });
            //    var result = ComputeCombination(combination);
            //    results.Add(result);

            //    data.Add(data[0]);
            //    data.RemoveAt(0);
            //}
            //return results.Max();
        }

        private int ComputeCombination(List<int> packageWeights)
        {
            int smallerPackage = 0;
            int largerPackage = 0;
            int? index = null;

            for (int i = 0; i < packageWeights.Count - 1; i++)
            {
                if (packageWeights[i] < packageWeights[i + 1] && packageWeights[i + 1] > largerPackage)
                {
                    smallerPackage = packageWeights[i];
                    largerPackage = packageWeights[i + 1];
                    index = i;
                }
            }

            if (index.HasValue)
            {
                int combinedWeight = smallerPackage + largerPackage;
                packageWeights[index.Value + 1] = combinedWeight;
                packageWeights.RemoveAt(index.Value);

                ComputeCombination(packageWeights);
            }
            return packageWeights.Max();
        }


        //if (packageWeights.Count > 2)
        //{
        //    ComputeCombination(packageWeights);
        //}
        //return packageWeights.Max();

        private int PowerQuestion()
        {
            //List<int> power = new List<int>() { 2, 3, 2, 1 };
            List<int> power = new List<int>() { 1,3,4 };
            int result = 0;
            
            for (int i = 0; i < power.Count; i++)
            {
                for (int j = i; j < power.Count; j++)
                {

                    result += (power[i] * power[i]);

                    if (i == j)
                    {
                        result += (power[i] * power[i]);
                    }
                    else
                    {
                        result += (Math.Min(power[i], power[j]) * (power[i] + power[j]));
                    }
                }
            }
            return result;
        }


        //private int PowerQuestion()
        //{
        //    List<int> power = new List<int>() { 2, 3, 2, 1 };
        //    //List<int> power = new List<int>() { 1,3,4 };
        //    int result = 0;
        //    for (int i = 0; i < power.Count; i++)
        //    {
        //        for (int j = i; j < power.Count; j++)
        //        {
        //            //result += (Math.Min(power[i], power[j]) + (power[i] + power[j]));
        //            result += (Math.Min(power[i], power[j]) * (power[i] + power[j]));
        //        }
        //    }
        //    return result;
        //}

    }
}
