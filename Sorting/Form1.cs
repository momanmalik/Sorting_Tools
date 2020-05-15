//SORTING METHODS
//SORTING METHODS PRACTICE
//MOMAN MALIK
//2018/12/05 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace Sorting
{
    public partial class Form1 : Form
    {
        //declare variables
        int[] unsorted;//aray for random unsorted numbers
        int amountSelected;//amount of random numbers user wants to create
        int[] numbersInt;//all the numbers int
        string[] numbers;//text file for numbers
        Random rand = new Random();//random number
        Boolean generated;//boolean to check if the user has generated any numbers
        Boolean sorted = false; //boolean to check if the array is already sorted

        //bubble sort vars
        int[] BSort;
        int bubbleComp; //amount of comparisons 
        int bubbleSwitch; //amount of switches
        int bTemp; //temp place holder variable
        Stopwatch bubbleTime = new Stopwatch();     //stop watch 
        Boolean bubbleSorted = false;

        //delay sort
        int[] DSort;
        int delayComp; //amount of comparisons
        int delaySwitch; //amount of switches
        int next; //the next number to be compared
        int smallest; //the smallest number so far
        int scout; //the scout to search for a smaller number
        int dTemp; //temp place holder
        int pos; //position of smallest number
        Stopwatch delayTime = new Stopwatch(); //stopwatch
        Boolean delaySorted = false;

        //quick sort
        int[] QSort;
        public int quickComp; //number of comparisons in quick sort
        public int quickSwitch; //number of switches in quick sort 
        Stopwatch quickTime = new Stopwatch(); //stopwatch
        Boolean quickSorted = false;

        //heap sort
        int[] HSort;
        private int heapSize; //variable for the heapsize
        int heapComp; //numbers of comparisons in heapsort
        int heapSwitch; //numbers of switches in heapsort
        Stopwatch heapTime = new Stopwatch(); //stopwatch
        Boolean heapSorted = false;

        //initialize form
        public Form1()
        {
            InitializeComponent();
            
        }

        //GENERATE RANDOM NUMBERS BUTTON ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void genBtn_Click(object sender, EventArgs e)
        {
            output.Items.Clear();
            if (numRand.Text == "")
            {
                MessageBox.Show("Please select a value!", "Error");
            }
            else
            {
                //boolean generated is true to show user has generated
                generated = true;

                amountSelected = Convert.ToInt32(numRand.Text);
                unsorted = new int[amountSelected];
                numbers = new string[amountSelected];
                for (int i = 0; i < amountSelected; i++)
                {
                    unsorted[i] = rand.Next(1, (amountSelected * 2));
                    output.Items.Add(+unsorted[i]);
                    numbers[i] = Convert.ToString(unsorted[i]);
                }

                //write the unsorted numbers to a file
                //open file
                StreamWriter outputFile = File.CreateText("unsorted.txt");
                //write to file
                foreach (string oneLine in numbers)
                {
                    outputFile.WriteLine(oneLine);
                }
                //close file
                outputFile.Close();
            }

            //since a new array is generated, we need to set all the sorted booleans to false
            bubbleSorted = false;
            quickSorted = false;
            heapSorted = false;
            delaySorted = false;
            sorted = false;

        }


        //SORT ALL BUTTON ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSortSelected_Click(object sender, EventArgs e)
        {
            if (sorted == false && generated == true)
            {
                //reset all variable
                bubbleTime.Reset();
                bubbleComp = 0;
                bubbleSwitch = 0;
                delayTime.Reset();
                delayComp = 0;
                delaySwitch = 0;
                quickTime.Reset();
                quickComp = 0;
                quickSwitch = 0;
                heapTime.Reset();
                heapComp = 0;
                heapSwitch = 0;
                output.Items.Clear();

                //initialize all arrays
                BSort = new int[amountSelected];
                DSort = new int[amountSelected];
                QSort = new int[amountSelected];
                HSort = new int[amountSelected];

                //collect unsorted array data 
                for (int i = 0; i < amountSelected; i++)
                {
                    BSort[i] = unsorted[i];
                    HSort[i] = unsorted[i];
                    QSort[i] = unsorted[i];
                    DSort[i] = unsorted[i];
                }

                //BUBBLE SORT
                //start the timer for bubble 
                

                bubbleTime.Start();

                //perform buble sort
                BubbleSort(BSort);

                //stop the timer for bubble sort
                bubbleTime.Stop();

                //labels updated
                lblBComp.Text = Convert.ToString(bubbleComp);
                lblBSwitch.Text = Convert.ToString(bubbleSwitch);
                lblBNum.Text = Convert.ToString(amountSelected);
                lblBTime.Text = Convert.ToString(bubbleTime.Elapsed);

                //convert to string so it can be inputted in file
                for (int i = 0; i < amountSelected; i++)
                {
                    numbers[i] = Convert.ToString(BSort[i]);
                }
                //write the bubblesorted numbers to a file
                //open file
                StreamWriter outputFile = File.CreateText("bubblesorted.txt");

                //convert to string so it can be inputted in file
                for (int i = 0; i < amountSelected; i++)
                {
                    numbers[i] = Convert.ToString(BSort[i]);
                }

                //write to file
                foreach (string oneLine in numbers)
                {
                    outputFile.WriteLine(oneLine);
                }

                //close file
                outputFile.Close();



                //HEAP SORT
                //start the heapsort stopwatch

                heapTime.Start();

                //perform heapsort
                BuildHeap(HSort, ref heapSwitch, ref heapComp);

                //set the heap sorted variable to true
                sorted = true;

                //final loop for sorted heap
                for (int i = HSort.Length - 1; i >= 0; i--)
                {
                    //swaps two variables
                    swap(ref HSort[0], ref HSort[i]);

                    //subtracts one from the heap size
                    heapSize--;

                    //performs heapify
                    Heapify(HSort, 0, ref heapSwitch, ref heapComp);
                }

                //stop the heapsort stopwatch
                heapTime.Stop();

                //update labels
                lblHComp.Text = Convert.ToString(heapComp);
                lblHSwitch.Text = Convert.ToString(heapSwitch);
                lblHTime.Text = Convert.ToString(heapTime.Elapsed);
                lblHNum.Text = Convert.ToString(amountSelected);

                //convert to string so it can be inputted in file
                for (int i = 0; i < amountSelected; i++)
                {
                    numbers[i] = Convert.ToString(HSort[i]);
                }

                //write the heapsorted numbers to a file
                //open file
                StreamWriter outputFile1 = File.CreateText("heapsorted.txt");

                //write to file
                foreach (string oneLine in numbers)
                {
                    outputFile1.WriteLine(oneLine);
                }

                //close file
                outputFile1.Close();



                //QUICK SORT
                //start the quick time stopwatch
                quickTime.Start();

                //perform quick sort
                Quick_Sort(QSort, 0, amountSelected - 1, ref quickComp, ref quickSwitch);

                //perform insertion sort
                InsertionSort(QSort, 0, amountSelected - 1, ref quickComp, ref quickSwitch);

                //end the quick time stopwatch
                quickTime.Stop();

                //set the quick sorted variable to true
                sorted = true;

                //update labels
                lblQComp.Text = Convert.ToString(quickComp);
                lblQSwitch.Text = Convert.ToString(quickSwitch);
                lblQTime.Text = Convert.ToString(quickTime.Elapsed);
                lblQNum.Text = Convert.ToString(amountSelected);

                //convert to string so it can be inputted in file
                for (int i = 0; i < amountSelected; i++)
                {
                    numbers[i] = Convert.ToString(QSort[i]);
                }

                //write quicksorted numbers to a file
                //open file
                StreamWriter outputFile2 = File.CreateText("quicksorted.txt");

                //write to file
                foreach (string oneLine in numbers)
                {
                    outputFile2.WriteLine(oneLine);

                }
                //close file
                outputFile2.Close();


                //DELAY SORT
                output.Items.Clear();
                delayComp = 0;
                delaySwitch = 0;
                delayTime.Reset();

                //place holder
                pos = 0;

                //start the delay time stop watch
                delayTime.Start();

                //perform delay sort
                DelaySort(DSort, ref delayComp, ref delaySwitch);

                //stop the delay time stopwatch 
                delayTime.Stop();

                //make the boolean true
                lblDComp.Text = Convert.ToString(delayComp);
                lblDSwitch.Text = Convert.ToString(delaySwitch);
                lblDTime.Text = Convert.ToString(delayTime.Elapsed);
                lblDNum.Text = Convert.ToString(amountSelected);

                //convert to string so it can be inputted in file
                for (int i = 0; i < amountSelected; i++)
                {
                    numbers[i] = Convert.ToString(QSort[i]);
                }

                //write quicksorted numbers to a file
                //open file
                StreamWriter outputFile3 = File.CreateText("delaysorted.txt");

                //write to file
                foreach (string oneLine in numbers)
                {
                    outputFile3.WriteLine(oneLine);

                }

                //everything is sorted so the boolean sorted is true
                sorted = true;        
                
                //print the sorted file
                //add items to text box
                for (int i = 0; i < amountSelected; i++)
                {
                    output.Items.Add(+DSort[i]);
                }
            }
            //if there is no numbers generate display error
            else if (generated == false)
            {
                MessageBox.Show("You must generate numbers in the random number generator before sorting!", "Error");
            }          
            //if the list is already sorted, display an error
            else if (sorted == true)
            {
                MessageBox.Show("The list of numbers are already sorted. To conduct another test, please generate new numbers.", "ERROR");
            }
        }


        //SORT SELECTED BUTTON ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSortAll_Click(object sender, EventArgs e)
        {
            //reset all vrariables
            bubbleTime.Reset();
            bubbleComp = 0;
            bubbleSwitch = 0;

            //initialize array
            numbersInt = new int[amountSelected];

            //convert to integer array
            for (int i = 0; i < amountSelected; i++)
            {
                numbersInt[i] = Convert.ToInt32(numbers[i]);
            }

            //if no numbers are generated, show error
            if (generated == false)
            {
                MessageBox.Show("You must generate numbers in the random number generator before sorting!", "Error");
            }
            else //if numbers are generated continue
            {

                //if else to see which sort is selected
                //BUBBLE SORT
                if (btnBubble.Checked == true)
                {
                    if (sorted == false)
                    {
                        //reset all variables and clear text box
                        bubbleComp = 0;
                        bubbleSwitch = 0;
                        bubbleTime.Reset();
                        output.Items.Clear();

                        //start the timer for bubble
                        bubbleTime.Start();

                        //run the bubble sort method
                        BubbleSort(numbersInt);

                        //stop the timer
                        bubbleTime.Stop();

                        //set the bubble sorted variable to true
                        sorted = true;

                        //labels updated
                        lblBComp.Text = Convert.ToString(bubbleComp);
                        lblBSwitch.Text = Convert.ToString(bubbleSwitch);
                        lblBNum.Text = Convert.ToString(amountSelected);
                        lblBTime.Text = Convert.ToString(bubbleTime.Elapsed);

                        //add items to text box and convert for the outputfile
                        for (int i = 0; i < amountSelected; i++)
                        {
                            output.Items.Add(+numbersInt[i]);
                            numbers[i] = Convert.ToString(numbersInt[i]);
                        }

                        //write the bubblesorted numbers to a file
                        //open file
                        StreamWriter outputFile = File.CreateText("bubblesorted.txt");

                        //write to file
                        foreach (string oneLine in numbers)
                        {
                            outputFile.WriteLine(oneLine);
                        }

                        //close file
                        outputFile.Close();
                    }
                    
                    //show error if the numbers are already sorted
                    else {
                        MessageBox.Show("The list of numbers are already sorted. To conduct another test, please generate new numbers.", "ERROR");
                    }
                }


                //HEAP SORT
                else if (btnHeap.Checked == true)
                {
                    if (sorted == false)
                    {
                        //clear all vars
                        output.Items.Clear();
                        heapComp = 0;
                        heapSwitch = 0;
                        heapTime.Reset();

                        //start the heapsort stopwatch
                        heapTime.Start();

                        //perform heapsort
                        BuildHeap(numbersInt, ref heapSwitch, ref heapComp);

                        //set the heap sorted variable to true
                        sorted = true;
                        
                        //final loop for sorted heap
                        for (int i = numbersInt.Length - 1; i >= 0; i--)
                        {
                            //swaps two variables
                            swap(ref numbersInt[0], ref numbersInt[i]);
                            //subtracts one from the heap size
                            heapSize--;
                            //performs heapify
                            Heapify(numbersInt, 0, ref heapSwitch, ref heapComp);
                        }

                        //stop the heapsort stopwatch
                        heapTime.Stop();

                        //update labels
                        lblHComp.Text = Convert.ToString(heapComp);
                        lblHSwitch.Text = Convert.ToString(heapSwitch);
                        lblHTime.Text = Convert.ToString(heapTime.Elapsed);
                        lblHNum.Text = Convert.ToString(amountSelected);

                        //print array
                        for (int i = 0; i < amountSelected; i++)
                        {
                            output.Items.Add(+numbersInt[i]);
                            numbers[i] = Convert.ToString(numbersInt[i]);
                        }

                        //write the heapsorted numbers to a file
                        //open file
                        StreamWriter outputFile = File.CreateText("heapsorted.txt");

                        //write to file
                        foreach (string oneLine in numbers)
                        {
                            outputFile.WriteLine(oneLine);
                        }

                        //close file
                        outputFile.Close();
                    }                            
                    //show error if the numbers are already sorted
                    else
                    {
                        MessageBox.Show("The list of numbers are already sorted. To conduct another test, please generate new numbers.", "ERROR");
                    }

                }

                //QUICK SORT
                else if (btnQuick.Checked == true)
                {
                    if (sorted == false)
                    {
                        //reset all variables
                        quickTime.Reset();
                        quickComp = 0;
                        quickSwitch = 0;
                        output.Items.Clear();

                        //start the quick time stopwatch
                        quickTime.Start();

                        //perform quick sort
                        Quick_Sort(numbersInt, 0, amountSelected - 1, ref quickComp, ref quickSwitch);

                        //perform insertion sort
                        InsertionSort(numbersInt, 0, amountSelected - 1, ref quickComp, ref quickSwitch);

                        //end the quick time stopwatch
                        quickTime.Stop();

                        //set the quick sorted variable to true
                        sorted = true;

                        //display array in output box
                        for (int i = 0; i < amountSelected; i++)
                        {
                            output.Items.Add(+numbersInt[i]);
                            numbers[i] = Convert.ToString(numbersInt[i]);
                        }

                        //update labels
                        lblQComp.Text = Convert.ToString(quickComp);
                        lblQSwitch.Text = Convert.ToString(quickSwitch);
                        lblQTime.Text = Convert.ToString(quickTime.Elapsed);
                        lblQNum.Text = Convert.ToString(amountSelected);

                        //write quicksorted numbers to a file
                        //open file
                        StreamWriter outputFile = File.CreateText("quicksorted.txt");

                        //write to file
                        foreach (string oneLine in numbers)
                        {
                            outputFile.WriteLine(oneLine);

                        }
                        //close file
                        outputFile.Close();
                    }
                    //show error if the numbers are already sorted
                    else
                    {
                        MessageBox.Show("The list of numbers are already sorted. To conduct another test, please generate new numbers.", "ERROR");
                    }

                }

                //DELAY SORT
                else if (btnDelay.Checked == true)
                {
                    if (sorted == false)
                    {
                        //clear the text box and reset all variables
                        output.Items.Clear();
                        delayComp = 0;
                        delaySwitch = 0;
                        delayTime.Reset();

                        //place holder
                        pos = 0;

                        //start the delay time stop watch
                        delayTime.Start();

                        //perform delay sort
                        DelaySort(numbersInt, ref delayComp, ref delaySwitch);
                        
                        //stop the delay time stopwatch 
                        delayTime.Stop();

                        //set the delay sorted variable to true
                        sorted = true;

                        //add items to text box
                        for (int i = 0; i < amountSelected; i++)
                        {
                            output.Items.Add(+numbersInt[i]);
                            numbers[i] = Convert.ToString(numbersInt[i]);
                        }

                        //make the boolean true
                        lblDComp.Text = Convert.ToString(delayComp);
                        lblDSwitch.Text = Convert.ToString(delaySwitch);
                        lblDTime.Text = Convert.ToString(delayTime.Elapsed);
                        lblDNum.Text = Convert.ToString(amountSelected);

                        //open file
                        StreamWriter outputFile = File.CreateText("delaysorted.txt");
                        //write to file
                        foreach (string oneLine in numbers)
                        {
                            outputFile.WriteLine(oneLine);
                        }
                        //close file
                        outputFile.Close();
                    }
                    //show error if the numbers are already sorted
                    else
                    {
                        MessageBox.Show("The list of numbers are already sorted. To conduct another test, please generate new numbers.", "ERROR");
                    }

                }

            }
        }

        //QUICK SORT ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void Quick_Sort(int[] array, int left, int right, ref int quickcomp, ref int quickswitch)
        {
            //declars vars
            int i;
            int j;
            int v;

            //if right minus left is greater than 8 do comparisons
            if ((right - left) > 8)
            {
                i = (right + 1) / 2;

                //if comparisons are true switch variables and add one to the switch
                if (array[left] > array[i])
                {
                    swap(ref array[left], ref array[i]);
                    quickswitch++;
                }
                else if (array[left] > array[right])
                {
                    swap(ref array[left], ref array[right]);
                    quickswitch++;
                }
                else if (array[i] > array[right])
                {
                    swap(ref array[i], ref array[right]);
                    quickswitch++;
                }

                //add three to the comparisons since there is three if statements
                quickcomp += 3;
                
                //j = right minus one
                j = right - 1;

                //switch array at i and array at j
                swap(ref array[i], ref array[j]);
                i = left;
                v = array[j];

                //for loop that breaks at an if statement
                for (; ;)
                {
                    //add one to the comparisonbefore and in each while statement
                    quickcomp++;
                    while (array[++i] < v)
                    {
                        quickcomp++;
                    }
                    quickcomp++;
                    while (array[--j] > v)
                    {
                        quickcomp++;
                    }
                    //if j is less than i break the loop
                    if (j < i)
                    {
                        break;
                    }
                    //swap the arary at i with the array at j
                    swap(ref array[i], ref array[j]);
                }

                //swap arary at i with array at right - 1
                swap(ref array[i], ref array[right - 1]);

                //add one to the quickswitch
                quickswitch++;

                //recursive quick sort
                Quick_Sort(array, left, j, ref quickcomp, ref quickswitch);
                Quick_Sort(array, i + 1, right, ref quickcomp, ref quickswitch);
            }           
        }

        //INSERTION SORT - EXTENSION OF QUICKSORT 
        public void InsertionSort(int[] array, int low0, int high0, ref int quickcomp, ref int quickswitch)
        {
            //declare vars
            int i;
            int j;
            int v;

            //for loop that ends if i is greater than or equal to high0
            for (i = low0 + 1; i <= high0; i++)
            {
                //initilize variables
                v = array[i];
                j = i;
                //while loop adds one to number of comparisons and switches
                while ((j > low0) && (array[j - 1] > v))
                {
                    array[j] = array[j - 1];
                    quickswitch++;
                    j--;
                    quickcomp++;
                }
                //makes array at j equal to v
                array[j] = v;
            }
        }
       
        //UNIVERSAL SWAP METHOD ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void swap<T>(ref T one, ref T two)
        {
            var temp = one;
            one = two;
            two = temp;
        }
        

        //HEAP SORT METHOD ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //build the heap
        private void BuildHeap(int[] array, ref int quickswitch, ref int quickcomp)
        {
             //the heap size is 1 less than the arrays length
             heapSize = array.Length - 1;
             //loop to build heap
             for (int i = heapSize / 2; i >= 0; i--)
             {
                 //inputs values including number of switches and comparisons
                 Heapify(array, i, ref quickswitch, ref quickcomp);
             }
        }

        //heapify class
        private void Heapify(int[] array, int index, ref int quickswitch, ref int quickcomp) {
            //main vars

            int left = index * 2;
            int right = index * 2 + 1;
            int largest = index;

            //all comparisions
            if (left <= heapSize && array[left] > array[index])
            {
                largest = left;
                
                //add one to the switch because the variable is switching
                quickswitch++;
            }
            if (right <= heapSize && array[right] > array[largest]) {
                largest = right;

                //add one to the switch because the variable is switching
                quickswitch++;
            }
            //if the largest is not the index than swap and repeat heapify
            if (largest != index) {
                //add one to the switch because swap occurs
                quickswitch++;
                //swap the two variables
                swap(ref array[index], ref array[largest]);
                //recursive heapify
                Heapify(array, largest, ref quickswitch, ref quickcomp);
            }
            //add three comparisons as there is three if statements
            heapComp += 3;
        }


        //BUBBLE SORT ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void BubbleSort(int[] array) {
            //two for loops for easy comparisons
            for (int i = 0; i < amountSelected; i++)
            {
                for (int j = 0; j < amountSelected; j++)
                {
                    bubbleComp++;
                    //comparison of the first number to the second, if first is greater than second switch them
                    if (array[i] < array[j])
                    {
                        //user swap method to swap two variables
                        swap(ref array[i],ref array[j]);
                        //add one to the number of switches
                        bubbleSwitch++;
                    }
                }
            }
        }


        //DELAY SORT ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void DelaySort(int[] array, ref int delaycomp, ref int delayswitch) {
            //for loop 
            for (int i = 0; i < amountSelected; i++)
            {
                //sets the next and smallest at i 
                next = array[i];
                smallest = array[i];

                //flr loop to search for a smaller number
                for (int j = i + 1; j < amountSelected; j++)
                {
                    //the scout starts at one after the i
                    scout = array[j];

                    //if the scouted number is less than the smallest
                    if (scout < smallest)
                    {
                        //add one to comparison 
                        delaycomp++;
                        //the smallest number is eqaul to the scout
                        smallest = scout;
                        //the position where we found the smallest number
                        pos = j;

                    }
                }

                //if the number at i is greater than smallest
                if (array[i] > smallest)
                {
                    //add one to delay switch
                    delayswitch++;

                    //swap the two numbers - we cannot use the swap method because there are 3 vars involved
                    dTemp = array[i];
                    array[i] = smallest;
                    array[pos] = dTemp;
                }
            }
        }


        //ignore
        private void Form1_Load(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
    }
}
