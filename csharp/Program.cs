using System; 
using static System.Console; 
Clear(); 
 
 
 
Write("Введите количество элементов массива: "); 
int m = Convert.ToInt32(ReadLine()); 
string [] stringArray = new string [m]; 
void array(string [] stringArray) 
{ 
  for (int i = 0;i<stringArray.Length;i++) 
  { 
     WriteLine($"Введите {i+1} элемент массива"); 
     stringArray[i] = ReadLine(); 
  } 
} 

string [] symbol(string [] stringArray) 
{ 
  int n = 0; 
  for (int i = 0;i<stringArray.Length;i++) 
  { 
    if(stringArray[i].Length <=3) 
    n++; 
  } 
  string [] rez = new string [n]; 
  int j = 0; 
  for (int i = 0;i<stringArray.Length;i++) 
  { 
    if(stringArray[i].Length <=3) 
    { 
        rez[j] = stringArray[i]; 
        j++; 
    } 
  } 
  return rez; 
} 
