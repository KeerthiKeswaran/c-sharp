using System;

namespace Program{

    // Class to manage and process a list of strings
    public class StringManagement{
        List<String> stringList = new List<String>();

        // Add a processed string to list
        public void addString(String s){
            string processedStr = processInput(s);
            this.stringList.Add(processedStr);
            Console.WriteLine("Added: " + processedStr);
        }

        // Standardize string by trimming and removing spaces
        public string processInput(string s){
            string processed = s.ToLower();
            processed = s.Trim();
            processed = s.Replace(" ", "");
            return processed;
        }

        // Remove a string from list after processing input
        public void removeString(String s){
            string processedStr = processInput(s);
            this.stringList.Remove(processedStr);
            Console.WriteLine("Removed: " + processedStr);
        }

        // Output current list state
        public void display(){
            Console.WriteLine("Current List: ");
            Console.Write("[ ");
            foreach(String s in this.stringList){
                Console.Write(s+" ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }

    class Program{
        static void Main(string[] args){
            StringManagement sm = new StringManagement();
            
            // Populate the list
            sm.addString("Keshwanth");
            sm.addString("Priya");
            sm.addString("Kavya");
            sm.display();
            
            // Remove an item and show updated list
            sm.removeString("Priya");
            sm.display();
        }
    }
}