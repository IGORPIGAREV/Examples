int[] array ={12,23,13,24,52,63,74,38,23};
int n =array.Length;// В переменную п записываем размер массива.
int find = 23 ;

int index = 0;
while (index<n)
{
    if (array[index] == find) Console.WriteLine("Порядковый номер:"+index);
    index++;//index=index+1;
}    