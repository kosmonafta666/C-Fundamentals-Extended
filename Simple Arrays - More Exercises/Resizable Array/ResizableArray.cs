namespace Resizable_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ResizableArray
    {
        public static void Main(string[] args)
        {
            var commands = Console.ReadLine();

            //array for result;
            var result = new long?[4];

            while (commands != "end")
            {
                switch (commands.Split(' ')[0])
                {
                    case "push":
                        //var for command2;
                        var command2 = commands.Split(' ')[1];
                        result = Push(result, long.Parse(command2));
                        break;
                    case "pop":
                        result = Pop(result);
                        break;
                    case "removeAt":
                        //var for command3;
                        var command3 = commands.Split(' ')[1];
                        result = RemoveAt(result, int.Parse(command3));
                        break;
                    case "clear":
                        result = Clear(result);
                        break;
                }


                commands = Console.ReadLine();
            }

            if (result.All(x => x == null))
            {
                Console.WriteLine("empty array");
            }
            else 
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }


        //method for push the new value;
        public static long?[] Push(long?[] array, long value) 
        {
            //var for length of the array;
            var length = array.Length;

           //bool for checking if array is full;
            bool flag = false;

            //check if array is full;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            //if is full double the length;
            if (!flag)
            {
                length = 2 * length;
            }

            //var for result array;
            var result = new long?[length];

            //copy from source to result;
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }

            //copy new value to result array;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null)
                {
                    continue;
                }
                else
                {
                    result[i] = value;
                    break;
                }
            }

            return result;
        }

        //method for pop the last element;
        public static long?[] Pop(long?[] array)
        {
            //array for new result;
            var result = new long?[array.Length];
            //var for count of existing elements;
            var countElements = 0;

            //find the existing elements;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    countElements++;
                }
            }

            //fill the new array result;
            for (int i = 0; i < countElements - 1; i++)
            {
                result[i] = array[i];
            }

            return result;
        }

        //method for remove value from givven index
        public static long?[] RemoveAt(long?[] array, int index)
        {
            //array for result;
            var result = new long?[array.Length];

            if (index >= 0 && index < array.Length)
            {
                //make null at position index;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == index)
                    {
                        result[i] = null;
                    }
                    else
                    {
                        result[i] = array[i];
                    }
                }

                //fill the result;
                for (int i = index + 1; i < array.Length; i++)
                {
                    result[i - 1] = array[i];
                }

                return result;
            }
            else
            {
                return array;
            }
        }

        //method for clear the array;
        public static long?[] Clear(long?[] array)
        {
            //array for result;
            var result = new long?[4];

            return result;
        }
    }
}
