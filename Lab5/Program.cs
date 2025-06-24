using System.Collections;

//-----------------------------------1.ArrayList--------------------------

//ArrayList A1 = new ArrayList();

//A1.Add(23);
//A1.Add("Kunj");
//A1.Add(true);
//A1.Add("Esha");
//A1.Add("Krisha");
//A1.Add("Nidhi");
//A1.Add("Palak");
//A1.Add("Drashti");
//A1.Add("Parth");
//for(int i = 0; i < A1.Count; i++)
//{
//    Console.WriteLine(A1[i]);
//}

//Console.WriteLine("\n");

//A1.Remove(7);
////A1.RemoveAt(10);          --> exception

//A1.RemoveRange(3, 3);

//for (int i = 0; i < A1.Count; i++)
//{
//    Console.WriteLine(A1[i]);
//}
//Console.WriteLine("Contains : "+ A1.Contains("Parth"));

////Equals check the whole object, for specific, give index
//Console.WriteLine("Equals : " + A1[1].Equals("Kunj"));

//Console.WriteLine("\n");

//A1.Insert(2,"Hello");

//foreach (object obj in A1)
//{
//    Console.WriteLine(obj.ToString());
//}

//-----------------------------------2.List------------------------------

//List<string> li = new List<string>();
//li.Add("23");
//li.Add("Kunj");
//li.Add("Hello");
//li.Add("Esha");
//li.Add("Krisha");
//li.Add("Nidhi");
//li.Add("Palak");
//li.Add("Drashti");
//li.Add("Parth");

//foreach(string s in li)
//{
//    Console.WriteLine(s);
//}

//li.Remove("Hello");
//li.RemoveAt(li.Count - 2);
//li.RemoveRange(4, 3);
//li.RemoveAll(li => li.Contains("Hello")); //--> removes all where that condition matches
                                          
//Console.WriteLine("------------------");

//foreach(string s in li)
//{
//    Console.WriteLine(s);
//}

//li.Clear();

//-------------------------------3.Stack-------------------------------

//Stack st = new Stack();

//st.Push(2);
//st.Push(3);
//st.Push("Hello");
//st.Push("from");
//st.Push("Kunj");
//st.Push("Temp");

//foreach (var i in st)
//{
//    Console.WriteLine(i);
//}

//st.Pop();

//Console.WriteLine("Peeking : " + st.Peek());

//Console.WriteLine("Contains Kunj : "+ st.Contains("Kunj"));

//st.Clear();

//--------------------------4.Queue------------------------------

Queue qu = new Queue();

st.Push(2);
st.Push(3);
st.Push("Hello");
st.Push("from");
st.Push("Kunj");
st.Push("Temp");

foreach (var i in st)
{
    Console.WriteLine(i);
}

st.Pop();

Console.WriteLine("Peeking : " + st.Peek());

Console.WriteLine("Contains Kunj : " + st.Contains("Kunj"));

st.Clear();
