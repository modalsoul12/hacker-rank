using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    class Program
    {
        #region Algorithms

        #region Circular Array Rotation

        //static void Main(String[] args)
        //{
        //    string[] vars = Console.ReadLine().Split(' ');

        //    int numInputs = Convert.ToInt32(vars[0]);
        //    int numRotations = Convert.ToInt32(vars[1]);
        //    int numQueries = Convert.ToInt32(vars[2]);

        //    string[] arr = Console.ReadLine().Split(' ');

        //    string[] rotatedArr = new string[arr.Length];

        //    if(numRotations > numInputs)
        //    {
        //        numRotations = numRotations % numInputs;    
        //    }

        //    for (int j = 0; j < arr.Length; j++)
        //    {
        //        int iPos = j + numRotations >= arr.Length ? (j + numRotations) - arr.Length : j + numRotations;
        //        rotatedArr[iPos] = arr[j];
        //    }


        //    StringBuilder sbOutput = new StringBuilder();
        //    for (int k = 0; k < numQueries; k++)
        //    {
        //        sbOutput.Append(rotatedArr[Convert.ToInt32(Console.ReadLine())]).Append(Environment.NewLine);
        //    }

        //    Console.WriteLine(sbOutput.ToString());

        //    Console.ReadKey();
        //}

        #endregion

        #region Chocolate in Box
        //Two players take turns taking chocolates from a box.
        //One who is not able to take any chocolates loses the game.
        //Find optimal first turn as player one to win.
        //Print 0 if not possible.
        static void Main(String[] args)
        {
            int iContainers = Convert.ToInt32(Console.ReadLine());
            string[] vars = Console.ReadLine().Split(' ');

            int[] numChocolates = new int[vars.Length];

            int iSumChocolates = 0;

            for(int i = 0; i < vars.Length; i++)
            {
                numChocolates[i] = Convert.ToInt32(vars[i]);
                iSumChocolates += numChocolates[i];
            }

            //Test Case 1
            //2
            //2 3
            //Answer: 1

            //Test Case 2
            //5
            //251149 86127 711523 501067 617190
            //Answer: 1

            //Test Case 3
            //10
            //189244 233165 896197 173284 638689 15877 272091 737304 325404 443303
            //Answer: 3


            Console.ReadKey();
        }
        #endregion

        #endregion

        #region 30 Day Challenge

        #region Palindromes

        //static void Main(String[] args)
        //{
        //    string input = Console.ReadLine();
        //
        //    Console.WriteLine(isPalindrome(input));
        //
        //    Console.ReadKey();
        //}

        //static bool isPalindrome(string input)
        //{
        //    for (int i = 0; i < input.Length / 2; i++)
        //    {
        //        if (input[i] != input[input.Length - i - 1])
        //        {
        //            return false;
        //        }
        //    }
        //
        //    return true;
        //}

        #endregion

        #region Day 18 Queues and Stacks
        //public List<char> stack = new List<char>();
        //public List<char> queue = new List<char>();

        //void pushCharacter(char ch)
        //{
        //    stack.Insert(0, ch);
        //}

        //void enqueueCharacter(char ch)
        //{
        //    queue.Add(ch);
        //}

        //char popCharacter()
        //{
        //    char top = stack[0];
        //    stack.RemoveAt(0);
        //    return top;
        //}

        //char dequeueCharacter()
        //{
        //    char last = queue[0];
        //    queue.RemoveAt(0);
        //    return last;
        //}

        //static void Main(string[] args)
        //{

        //    // read the string s.
        //    string s = Console.ReadLine();

        //    // create the Solution class object p.
        //    Program obj = new Program();

        //    // push/enqueue all the characters of string s to stack.
        //    foreach (char c in s)
        //    {
        //        obj.pushCharacter(c);
        //        obj.enqueueCharacter(c);
        //    }

        //    bool isPalindrome = true;

        //    // pop the top character from stack.
        //    // dequeue the first character from queue.
        //    // compare both the characters.
        //    for (int i = 0; i < s.Length / 2; i++)
        //    {
        //        if (obj.popCharacter() != obj.dequeueCharacter())
        //        {
        //            isPalindrome = false;

        //            break;
        //        }

        //    }

        //    // finally print whether string s is palindrome or not.
        //    if (isPalindrome)
        //    {
        //        Console.Write("The word, {0}, is a palindrome.", s);
        //    }
        //    else
        //    {
        //        Console.Write("The word, {0}, is not a palindrome.", s);
        //    }

        //    Console.ReadKey();
        //}
        #endregion

        #region Day 19 Interfaces

        //public interface AdvancedArithmetic
        //{
        //    int divisorSum(int n);
        //}

        //class Calculator : AdvancedArithmetic
        //{
        //    public int divisorSum(int n)
        //    {
        //        int iSum = 0;
        //        for (int i = 1; i <= n; i++)
        //        {
        //            if (n % i == 0)
        //            {
        //                iSum += i;
        //            }
        //        }

        //        return iSum;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int n = Int32.Parse(Console.ReadLine());
        //    AdvancedArithmetic myCalculator = new Calculator();
        //    int sum = myCalculator.divisorSum(n);

        //    Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        //    Console.ReadKey();
        //}

        #endregion

        #region Day 20 Bubble Sort

        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] a_temp = Console.ReadLine().Split(' ');
        //    int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        //    int numberOfSwaps = 0;
        //    for (int i = 0; i < n; i++)
        //    {

        //        for (int j = 0; j < n - 1; j++)
        //        {
        //            if (a[j] > a[j + 1])
        //            {
        //                int iTemp = a[j];
        //                a[j] = a[j + 1];
        //                a[j + 1] = iTemp;
        //                numberOfSwaps++;
        //            }
        //        }

        //        if (numberOfSwaps == 0)
        //        {
        //            break;
        //        }
        //    }

        //    Console.WriteLine("Array is sorted in " + numberOfSwaps + " swaps.");
        //    Console.WriteLine("First Element: " + a[0]);
        //    Console.WriteLine("Last Element: " + a[a.Length - 1]);

        //    Console.ReadKey();
        //}
        #endregion

        #region Day 21 Generics

        //static void Main(String[] args)
        //{
        //    int[] vInt = new int[] { 1, 2, 3 };
        //    string[] vString = new string[] { "Hello", "World" };

        //    printArray<int>(vInt);
        //    printArray<string>(vString);

        //    Console.ReadKey();
        //}

        //static void printArray<T>(T[] tArray)
        //{
        //    for (int i = 0; i < tArray.Length; i++)
        //    {
        //        Console.WriteLine(tArray[i]);
        //    }
        //}

        #endregion

        #region Day 22 Binary Search

        //class Node
        //{
        //    public Node left, right;
        //    public int data;
        //    public Node(int data)
        //    {
        //        this.data = data;
        //        left = right = null;
        //    }
        //}

        //    static void Main(String[] args)
        //    {
        //        //int n = Convert.ToInt32(Console.ReadLine());
        //        //string[] a_temp = Console.ReadLine().Split(' ');
        //        //int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        //        Node root = null;
        //        int T = Int32.Parse(Console.ReadLine());
        //        while (T-- > 0)
        //        {
        //            int data = Int32.Parse(Console.ReadLine());
        //            root = insert(root, data);
        //        }
        //        int height = getHeight(root);

        //        Console.WriteLine("Height: " + height);
        //        Console.ReadKey();

        //    }

        //    static int getHeight(Node root)
        //    {
        //        return root == null ? -1 : 1 + Math.Max(getHeight(root.left), getHeight(root.right));
        //    }

        //    static Node insert(Node root, int data)
        //    {
        //        if (root == null)
        //        {
        //            return new Node(data);
        //        }
        //        else
        //        {
        //            Node cur;
        //            if (data <= root.data)
        //            {
        //                cur = insert(root.left, data);
        //                root.left = cur;
        //            }
        //            else
        //            {
        //                cur = insert(root.right, data);
        //                root.right = cur;
        //            }
        //            return root;
        //        }
        //    }

        #endregion

        #region Day 23 BST Level-Order Traversal

        //static void Main(String[] args)
        //{
        //    Node root = null;
        //    int T = Int32.Parse(Console.ReadLine());
        //    while (T-- > 0)
        //    {
        //        int data = Int32.Parse(Console.ReadLine());
        //        root = insert(root, data);
        //    }
        //    levelOrder(root);

        //    Console.ReadKey();
        //}

        //class Node
        //{
        //    public Node left, right;
        //    public int data;
        //    public Node(int data)
        //    {
        //        this.data = data;
        //        left = right = null;
        //    }
        //}

        //static Node insert(Node root, int data)
        //{
        //    if (root == null)
        //    {
        //        return new Node(data);
        //    }
        //    else
        //    {
        //        Node cur;
        //        if (data <= root.data)
        //        {
        //            cur = insert(root.left, data);
        //            root.left = cur;
        //        }
        //        else
        //        {
        //            cur = insert(root.right, data);
        //            root.right = cur;
        //        }
        //        return root;
        //    }
        //}

        //static void levelOrder(Node root)
        //{
        //    //Write your code here
        //    string answer = "";
        //    List<Node> queue = new List<Node>() { root };

        //    while (queue.Count != 0)
        //    {
        //        int length = queue.Count;
        //        for (int i = 0; i < length; i++)
        //        {
        //            answer += queue[i].data + " ";

        //            if (queue[i].left != null)
        //            {
        //                queue.Add(queue[i].left);
        //            }

        //            if (queue[i].right != null)
        //            {
        //                queue.Add(queue[i].right);
        //            }
        //        }

        //        queue.RemoveRange(0, length);
        //    }

        //    Console.WriteLine(answer);
        //}

        #endregion

        #region Day 24 More Linked Lists (Removing Duplicates)

        //static void Main(String[] args)
        //{
        //    Node head = null;
        //    int T = Int32.Parse(Console.ReadLine());
        //    while (T-- > 0)
        //    {
        //        int data = Int32.Parse(Console.ReadLine());
        //        head = insert(head, data);
        //    }
        //    head = removeDuplicates(head);
        //    display(head);

        //    Console.ReadKey();
        //}

        //class Node
        //{
        //    public int data;
        //    public Node next;
        //    public Node(int d)
        //    {
        //        data = d;
        //        next = null;
        //    }

        //}

        //static Node removeDuplicates(Node head)
        //{
        //    //Write your code here

        //    if (head.next != null)
        //    {
        //        if (head.data == head.next.data)
        //        {
        //            head.next = head.next.next;
        //            removeDuplicates(head);
        //        }
        //        else
        //        {
        //            removeDuplicates(head.next);
        //        }
        //    }

        //    return head;
        //}

        //static Node insert(Node head, int data)
        //{
        //    Node p = new Node(data);


        //    if (head == null)
        //        head = p;
        //    else if (head.next == null)
        //        head.next = p;
        //    else
        //    {
        //        Node start = head;
        //        while (start.next != null)
        //            start = start.next;
        //        start.next = p;

        //    }
        //    return head;
        //}

        //static void display(Node head)
        //{
        //    Node start = head;
        //    while (start != null)
        //    {
        //        Console.Write(start.data + " ");
        //        start = start.next;
        //    }
        //}

        #endregion

        #region Day 25 Running Time and Complexity

        //static void Main(String[] args)
        //{
        //    int T = Int32.Parse(Console.ReadLine());
        //    List<int> queue = new List<int>();
        //    while (T-- > 0)
        //    {
        //        queue.Add(Convert.ToInt32(Console.ReadLine()));
        //    }

        //    foreach (int n in queue)
        //    {
        //        isPrime(n);
        //    }

        //    Console.ReadKey();
        //}

        //static void isPrime(int number)
        //{
        //    if (number == 1 || (number % 2 == 0 && number != 2))
        //    {
        //        Console.WriteLine("Not prime");
        //        return;
        //    }

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            Console.WriteLine("Not prime");
        //            return;
        //        }
        //    }

        //    Console.WriteLine("Prime");
        //}

        #endregion

        #region Day 26 Nested Logic

        //static void Main(String[] args)
        //{
        //    int[] actualDate = new int[3];
        //    int[] expectedDate = new int[3];

        //    string[] sTemp = Console.ReadLine().Split(' ');

        //    for (int i = 0; i < sTemp.Length; i++)
        //    {
        //        actualDate[i] = Convert.ToInt32(sTemp[i]);
        //    }

        //    sTemp = Console.ReadLine().Split(' ');

        //    for (int i = 0; i < sTemp.Length; i++)
        //    {
        //        expectedDate[i] = Convert.ToInt32(sTemp[i]);
        //    }

        //    int iFineAmount = 0;

        //    if (actualDate[2] > expectedDate[2])
        //    {
        //        iFineAmount = 10000;
        //    }
        //    else if (actualDate[1] > expectedDate[1] && actualDate[2] == expectedDate[2])
        //    {
        //        iFineAmount = 500 * (actualDate[1] - expectedDate[1]);
        //    }
        //    else if (actualDate[0] > expectedDate[0] && actualDate[1] == expectedDate[1] && actualDate[2] == expectedDate[2])
        //    {
        //        iFineAmount = 15 * (actualDate[0] - expectedDate[0]);
        //    }

        //    Console.WriteLine(iFineAmount);

        //    Console.ReadKey();
        //}

        #endregion

        #region Day 27 Testing

        //Instead of outputting test cases, i wrote the tests.

        //static void checkTestCases (int T)
        //{
        //    if(T > 5)
        //    {
        //        throw new Exception("There cannot be more than 5 test cases!");
        //    }
        //}

        //static void checkStudentsInClass(int N)
        //{
        //    if (N < 1 || N > 200)
        //    {
        //        throw new Exception("Number of students in class is out of range!");
        //    }
        //}

        //static void checkCancellationThreshold(int N, int K)
        //{
        //    if (K < 1 || K > N)
        //    {
        //        throw new Exception("Cancellation threshold is out of range!");
        //    }
        //}

        //static void checkStudentsInClass(int[] a, int N)
        //{
        //    if (a.Length > N)
        //    {
        //        throw new Exception("List of arrival times does not match number of students in class is out of range!");
        //    }

        //    for(int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] < -1000 || a[i] > 1000)
        //        {
        //            throw new Exception("Arrival time for student is out of range!");
        //        }
        //    }
        //}




        #endregion

        #region Day 28 RegEx, Patterns, and Intro to Databases

        //static void Main(String[] args)
        //{
        //    int N = Convert.ToInt32(Console.ReadLine());
        //    List<string> names = new List<string>();
        //    for (int a0 = 0; a0 < N; a0++)
        //    {
        //        string[] tokens_firstName = Console.ReadLine().Split(' ');
        //        string firstName = tokens_firstName[0];
        //        string emailID = tokens_firstName[1];

        //        Regex nameRegEx = new Regex("[a-z]{1,20}");
        //        Regex emailRegEx = new Regex("[a-z]{1,40}(@gmail.com)");
        //        bool bName = nameRegEx.IsMatch(firstName);
        //        bool bEmail = emailRegEx.IsMatch(emailID);

        //        if (nameRegEx.IsMatch(firstName) && emailRegEx.IsMatch(emailID))
        //        {
        //            names.Add(firstName);
        //        }
        //    }

        //    foreach (string name in names.OrderBy(x => x))
        //    {
        //        Console.WriteLine(name);
        //    }

        //    Console.ReadKey();
        //}

        #endregion

        #region Day 29 Bitwise AND

        //static void Main(String[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    StringBuilder output = new StringBuilder();
        //    for (int a0 = 0; a0 < t; a0++)
        //    {
        //        string[] tokens_n = Console.ReadLine().Split(' ');
        //        int n = Convert.ToInt32(tokens_n[0]);
        //        int k = Convert.ToInt32(tokens_n[1]);

        //        List<int> values = new List<int>();

        //        for(int i = 1; i < n; i++)
        //        {
        //            for(int j = i + 1; j <= n; j++)
        //            {
        //                int a = i & j;
        //                if(a < k)
        //                {
        //                    values.Add(a);
        //                }
        //                //Console.WriteLine("A = " + i + ", B = " + j + ", A & B = " + a);
        //            }
        //        }

        //        output.Append(values.Max()).Append(Environment.NewLine);
        //        //Console.WriteLine("Max of A&B that is < " + k + " = " + values.Where(x => x < k).Max());
        //    }

        //    Console.WriteLine(output.ToString());
        //    Console.ReadKey();
        //}

        #endregion

        #endregion
    }
}
