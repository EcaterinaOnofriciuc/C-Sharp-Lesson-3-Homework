

namespace C_Sharp_Lesson_3_Homework
{
    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            //int[,] matrix = new int[3,4];
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            if (matrixOfIntegers.GetLength(0) % 2 == 0 || matrixOfIntegers.GetLength(1) % 2 == 0)
            {
                Console.WriteLine("This matrix doesn't have a central element");
            }
            else
            {
                var rowNumber = matrixOfIntegers.GetLength(0) / 2;
                var columnNumber = matrixOfIntegers.GetLength(1) / 2;
                Console.WriteLine($"The central element is {matrixOfIntegers[rowNumber, columnNumber]}");
            }


        }
        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            if (matrixOfIntegers.GetLength(0) != matrixOfIntegers.GetLength(1))
            {
                Console.WriteLine("This matrix doesn't have diagonals");
            }
            else
            {
                var length = matrixOfIntegers.GetLength(0);
                var firstSum = 0;
                for (var i = 0; i < length; i++)
                {
                    firstSum += matrixOfIntegers[i, i];
                }
                var secondSum = 0;
                for (var i = 0; i < length; i++)
                {
                    secondSum += matrixOfIntegers[i, length - i - 1];
                }
                Console.WriteLine($"First Diagonal: {firstSum}");
                Console.WriteLine($"Second Diagonal: {secondSum}");
            }

        }
        public void StarPrinter(int triangleHeight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            for (int i = 0; i < triangleHeight; i++)
            {
                for (int j = 0; j <= triangleHeight - i; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                    if (j != i)
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
        }
        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            foreach (var x in listOfNumbers.OrderBy(x => x))
            {
                Console.Write(x);
                Console.Write(' ');
            }
        }

        public void CollectionOperations()
        {
            var listOfEmployees = new List<Employee>
            {
                new Employee("Ecaterina", "Onofriciuc"),
                new Employee("Ivan", "Popov"),
                new Employee("Igor", "Smirnov"),
                new Employee("Vasea", "Pupkin"),
                new Employee("Andrei", "Popescu")
            };

            listOfEmployees.Add(new Employee("Serghei", "Visotskii"));
            listOfEmployees.Add(new Employee("Serghei", "Prigov"));
            listOfEmployees.Add(new Employee("Serghei", "Mislinskii"));
            Console.WriteLine("\n\nList");
            foreach (var employee in listOfEmployees)
            {
                Console.WriteLine($"{employee.LastName} {employee.FirstName}");
            }

            Console.WriteLine("\n\nOrdered:");
            foreach (var employee in listOfEmployees.OrderBy(x => x.LastName).ThenByDescending(c => c.FirstName))
            {
                Console.WriteLine($"{employee.LastName} {employee.FirstName}");
            }
            Console.WriteLine($"\n\nCount: {listOfEmployees.Count}");
            listOfEmployees.Remove(listOfEmployees[0]);
            listOfEmployees.Remove(listOfEmployees.First());
            Console.WriteLine($"\n\nCount after remove: {listOfEmployees.Count}");

            listOfEmployees = listOfEmployees.Where(x => x.FirstName.Length <= 5 || x.FirstName == "Serghei").ToList();

            Console.WriteLine("\n\nAfter filter:");

            foreach (var employee in listOfEmployees)
            {
                Console.WriteLine($"{employee.LastName} {employee.FirstName}");
            }

            Console.WriteLine($"\n\nCount after filter: {listOfEmployees.Count}");

            listOfEmployees = listOfEmployees.DistinctBy(x => x.FirstName).ToList();
            Console.WriteLine("\n\nOrdered with distinct first name:");
            foreach (var employee in listOfEmployees.OrderByDescending(x => x.LastName))
            {
                Console.WriteLine($"{employee.LastName} {employee.FirstName}");
            }
        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(5);
            homework.SortList(list);

            homework.CollectionOperations();
        }

    }
}
