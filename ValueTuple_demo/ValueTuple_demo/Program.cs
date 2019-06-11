using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuple_demo
{
    class ValueTypedemo
    {
        public static (string techTopic,string decription,string featureAdded,string addressedIssues) GetValueTupleDetails(int techID)
        {
            string techTopic = "ValueTuple";
            string description = "Hold finite data in record manner";
            string featureAdded = "C#7.0";
            string addressedIssues = "out param \n i)can achieve multiple return values but need to declare variable with its types\n ii)(var can't be used,can't be used with async method),no custom naming, \n it was not advisable to use in performance centric,\n null cases need to handled";
            return (techTopic, description, featureAdded, addressedIssues);


        }
        public static (int empId,string empName,int salary) GetEmployeeDetails(int id)
        {
            int empId = 0076;
            string empName = "Banupriya";
            int salary = 20000000;
            return (empId, empName, salary);

        }
        public static void Printresults()
        {
            foreach (var suit in Enum.GetValues(typeof(enumuratetoenum.Suit)))
            {
                Console.WriteLine("val " + suit.ToString());
                Console.ReadLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int techID = 11;
            var (techTopic,description,featureAdded,addressedIssues) = ValueTypedemo.GetValueTupleDetails(techID);
            Console.WriteLine($"Tech Details : \n Tech ID :{techID} \n Tech Topic : {techTopic } \n Description: {description} \n"+
                $"\n Feature Added : {featureAdded} \n addressedIssues : {addressedIssues}");

            var (empID, empName, salary) = ValueTypedemo.GetEmployeeDetails(1);
            Console.WriteLine($"Employee Details : empID:{empID} \n employee Name : {empName} \n Salary :{salary}");
            Console.ReadLine();
            ValueTypedemo.Printresults();

        }
    }
}
