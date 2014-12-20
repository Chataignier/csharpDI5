using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Mercure
{
    class IniFile
    {
        /// <summary>
        /// Method used to get a string from the file
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        /// <param name="Name"></param>
        /// <param name="Default"></param>
        /// <returns></returns>
        public static string GetString(string FileName, string Section, string Name, string Default)
        {
            string Result = Default;

            // We check all the parameters

            if (string.IsNullOrEmpty(FileName))
            {
                throw new ArgumentException("FileName is empty");
            }

            if (string.IsNullOrEmpty(Section))
            {
                throw new ArgumentException("Section is empty");
            }

            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name is empty");
            }

            if (!File.Exists(FileName))
            {
                throw new FileNotFoundException("FileName doesn't exist");
            }

            using (StreamReader Stream = File.OpenText(FileName)) // We open the file
            {
                string CurrentLine = null;
                string CurrentSection = null;
                string CurrentName = null;
                Boolean stop = false;

                while (!stop && (CurrentLine = Stream.ReadLine()) != null)
                {
                    if (Regex.Match(CurrentLine, @"\[.+\]", RegexOptions.IgnoreCase).Success) // If the line is a new section
                    {
                        int tmpIndex = -1;
                        CurrentSection = CurrentLine.Trim();

                        if ((tmpIndex = CurrentSection.IndexOf(";")) != -1)
                        {
                            CurrentSection.Substring(0, tmpIndex);
                        }

                        CurrentSection = CurrentSection.Substring(1, CurrentSection.Length - 2); // We remove the first and last []    
                    }
                    else if (CurrentLine.StartsWith(";"))
                    {
                        // It's a comment (the line, not the comment, because of course this comment is a comment)
                    }
                    else if (Regex.Match(CurrentLine, @".+=.+", RegexOptions.IgnoreCase).Success) // If the line contains an attribute
                    {

                        if (CurrentSection == null) // If there is no section, the file has a problem
                        {
                            throw new Exception("File is not well formated");
                        }
                        else if (CurrentSection.Equals(Section)) // If we are in the correct section
                        {
                            CurrentName = CurrentLine.Substring(0, CurrentLine.IndexOf("=")).TrimEnd(); // We get the current name

                            if (CurrentName.Equals(Name) | CurrentName.Trim().Equals(Name)) // If this is the correct name, it's over
                            {
                                stop = true;
                                Result = CurrentLine.Substring(CurrentLine.IndexOf("=") + 1).Trim();

                                if (Result.StartsWith("\"") && Result.EndsWith("\"")) // We removed the " if it's needed
                                {
                                    Result = Result.Substring(1, Result.Length - 2);
                                }
                            }
                        }
                    }
                }
            }

            return Result;
        }

        /// <summary>
        /// Method used to get a string from the file
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static string GetString(string FileName, string Section, string Name)
        {
            return GetString(FileName, Section, Name, "Value Not Found");
        }

        /// <summary>
        /// Method used to get an integer from the file
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        /// <param name="Name"></param>
        /// <param name="Default"></param>
        /// <returns></returns>
        public static int GetInteger(string FileName, string Section, string Name, int Default)
        {
            int IntegerResult = Default;
            string StringResult = GetString(FileName, Section, Name, Default.ToString());

            try
            {
                IntegerResult = Convert.ToInt32(StringResult);
            }
            catch (FormatException Exception) // If it's not an integer
            {
                // We do nothing, we just let the default Value 
            }
            catch (OverflowException Exception) // If there is a overflow problem 
            {
                // We do nothing, we just let the default Value 
            }

            return IntegerResult;
        }

        /// <summary>
        /// Method used to get an integer from the file
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static int GetInteger(string FileName, string Section, string Name)
        {
            return GetInteger(FileName, Section, Name, 0);
        }

        /// <summary>
        /// Method used to get an attribute from the file
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        /// <param name="Name"></param>
        /// <param name="Default"></param>
        /// <returns></returns>
        public static object Get(string FileName, string Section, string Name, object Default)
        {
            if (Default is string)
            {
                return GetString(FileName, Section, Name, (string)Default);
            }
            else
            {
                return GetInteger(FileName, Section, Name, (int)Default);
            }
        }

        /// <summary>
        /// This method is used to write an new tag in a section with the corresponding value
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        /// <param name="Name"></param>
        /// <param name="Value"></param>
        public static void WriteString(string FileName, string Section, string Name, string Value)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                throw new ArgumentException("FileName is empty");
            }

            if (string.IsNullOrEmpty(Section))
            {
                throw new ArgumentException("Section is empty");
            }

            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name is empty");
            }

            if (string.IsNullOrEmpty(Value))
            {
                throw new ArgumentException("Value is empty");
            }

            if (!File.Exists(FileName))
            {
                File.Create(FileName);
            }

            if (!ContainsSection(FileName, Section))
            {
                WriteSection(FileName, Section);
            }

            using (StreamReader StreamR = File.OpenText(FileName)) // We open the file
            {
                string CurrentLine = null;
                string CurrentSection = null;
                string CurrentName = null;
                Boolean Stop = false;
                StreamWriter StreamW = new StreamWriter(@"c:\tmp.txt");

                while ((CurrentLine = StreamR.ReadLine()) != null)
                {
                    if (Stop)
                    { // If we've already writen the attribute, we just print the line
                        StreamW.WriteLine(CurrentLine);
                    }
                    else if (Regex.Match(CurrentLine, @"\[.+\]", RegexOptions.IgnoreCase).Success) // If the line is a new section
                    {
                        if (!string.IsNullOrEmpty(CurrentSection) && CurrentSection.Equals(Section)) // If we are out of the good section, we print the attribute
                        {
                            StreamW.WriteLine(Name + "=" + Value);
                            StreamW.WriteLine(CurrentLine);
                            Stop = true; // We don't need to check every time now, we just print in the file
                        }
                        else
                        {
                            int tmpIndex = -1;
                            CurrentSection = CurrentLine.Trim();

                            if ((tmpIndex = CurrentSection.IndexOf(";")) != -1)
                            {
                                CurrentSection.Substring(0, tmpIndex);
                            }

                            CurrentSection = CurrentSection.Substring(1, CurrentSection.Length - 2); // We remove the first and last []

                            StreamW.WriteLine(CurrentLine);
                        }
                    }
                    else if (Regex.Match(CurrentLine, @".+=.+", RegexOptions.IgnoreCase).Success) // If the line contains an attribute
                    {
                        if (CurrentSection == null) // If there is no section, the file has a problem
                        {
                            throw new Exception("File is not well formated");
                        }
                        else if (CurrentSection.Equals(Section)) // If we are in the correct section
                        {
                            CurrentName = CurrentLine.Substring(0, CurrentLine.IndexOf("=")).TrimEnd(); // We get the current name

                            if (CurrentName.Equals(Name) | CurrentName.Trim().Equals(Name)) // If this is the correct name, we erase the old value
                            {
                                StreamW.WriteLine(Name + "=" + Value);
                                Stop = true; // We don't need to check every time now, we just print in the file
                            }
                            else
                            {
                                StreamW.WriteLine(CurrentLine);
                            }
                        }
                        else
                        {
                            StreamW.WriteLine(CurrentLine);
                        }
                    }
                }

                if (!Stop && CurrentSection.Equals(Section)) // If we are at the end of the file and we've never printed the attribute
                {
                    StreamW.WriteLine(Name + "=" + Value);
                }

                StreamW.Dispose();
            }

            // Then we removed to old file and replace it with the new one
            File.Copy(@"c:\tmp.txt", FileName, true);
            File.Delete(@"c:\tmp.txt");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        /// <param name="Name"></param>
        /// <param name="Value"></param>
        public static void WriteInteger(string FileName, string Section, string Name, int Value)
        {
            WriteString(FileName, Section, Name, Value.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        /// <param name="Name"></param>
        /// <param name="Value"></param>
        public static void WriteName(string FileName, string Section, string Name, object Value)
        {
            if (Value is string)
            {
                WriteString(FileName, Section, Name, (string)Value);
            }
            else
            {
                WriteInteger(FileName, Section, Name, (int)Value);
            }
        }

        /// <summary>
        /// This method is used to write a new section at the end of the file
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        public static void WriteSection(string FileName, string Section)
        {
            if (ContainsSection(FileName, Section))
            {
                throw new ArgumentException("The Section already exists in the file");
            }
            else
            {
                File.AppendAllText(FileName, "[" + Section + "]");
            }
        }

        /// <summary>
        /// This method is used to know if the file contains or not a section with the name given in parameters
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        /// <returns></returns>
        public static Boolean ContainsSection(string FileName, string Section)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                throw new ArgumentException("FileName is empty");
            }

            if (string.IsNullOrEmpty(Section))
            {
                throw new ArgumentException("Section is empty");
            }

            if (!File.Exists(FileName))
            {
                throw new FileNotFoundException("FileName doesn't exist");
            }

            using (StreamReader Stream = File.OpenText(FileName)) // We open the file
            {
                string CurrentLine = null;
                string CurrentSection = null;
                Boolean stop = false;

                while (!stop && (CurrentLine = Stream.ReadLine()) != null)
                {
                    if (Regex.Match(CurrentLine, @"\[.+\]", RegexOptions.IgnoreCase).Success) // If the line is a new section
                    {
                        int tmpIndex = -1;
                        CurrentSection = CurrentLine.Trim();

                        if ((tmpIndex = CurrentSection.IndexOf(";")) != -1)
                        {
                            CurrentSection.Substring(0, tmpIndex);
                        }

                        CurrentSection = CurrentSection.Substring(1, CurrentSection.Length - 2); // We remove the first and last []

                        if (CurrentSection.Equals(Section))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// This method is used to remove an attribute from a given section
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        /// <param name="Name"></param>
        public static void RemoveAttribute(string FileName, string Section, string Name)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                throw new ArgumentException("FileName is empty");
            }

            if (string.IsNullOrEmpty(Section))
            {
                throw new ArgumentException("Section is empty");
            }

            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name is empty");
            }

            if (!File.Exists(FileName))
            {
                throw new ArgumentException("The file doesn't");
            }

            using (StreamReader StreamR = File.OpenText(FileName)) // We open the file
            {
                string CurrentLine = null;
                string CurrentSection = null;
                string CurrentName = null;
                Boolean Stop = false;
                StreamWriter StreamW = new StreamWriter(@"c:\tmp.txt");

                while ((CurrentLine = StreamR.ReadLine()) != null)
                {
                    if (Stop)
                    { // If we've already writen the attribute, we just print the line
                        StreamW.WriteLine(CurrentLine);
                    }
                    else if (Regex.Match(CurrentLine, @"\[.+\]", RegexOptions.IgnoreCase).Success) // If the line is a new section
                    {
                        int tmpIndex = -1;
                        CurrentSection = CurrentLine.Trim();

                        if ((tmpIndex = CurrentSection.IndexOf(";")) != -1)
                        {
                            CurrentSection.Substring(0, tmpIndex);
                        }

                        CurrentSection = CurrentSection.Substring(1, CurrentSection.Length - 2); // We remove the first and last []

                        StreamW.WriteLine(CurrentLine);
                    }
                    else if (Regex.Match(CurrentLine, @".+=.+", RegexOptions.IgnoreCase).Success) // If the line contains an attribute
                    {
                        if (CurrentSection == null) // If there is no section, the file has a problem
                        {
                            throw new Exception("File is not well formated");
                        }
                        else if (CurrentSection.Equals(Section)) // If we are in the correct section
                        {
                            CurrentName = CurrentLine.Substring(0, CurrentLine.IndexOf("=")).TrimEnd(); // We get the current name

                            if (CurrentName.Equals(Name) | CurrentName.Trim().Equals(Name)) // If this is the correct name, we erase the old value
                            {
                                Stop = true; // We don't need to check every time now, we just remove the line 
                            }
                            else
                            {
                                StreamW.WriteLine(CurrentLine);
                            }
                        }
                        else
                        {
                            StreamW.WriteLine(CurrentLine);
                        }
                    }
                }

                StreamW.Dispose();
            }

            // Then we removed to old file and replace it with the new one
            File.Copy(@"c:\tmp.txt", FileName, true);
            File.Delete(@"c:\tmp.txt");
        }

        /// <summary>
        /// This method is used to remove the given section
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Section"></param>
        public static void RemoveSection(string FileName, string Section)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                throw new ArgumentException("FileName is empty");
            }

            if (string.IsNullOrEmpty(Section))
            {
                throw new ArgumentException("Section is empty");
            }

            if (!File.Exists(FileName))
            {
                throw new ArgumentException("The file doesn't");
            }

            using (StreamReader StreamR = File.OpenText(FileName)) // We open the file
            {
                string CurrentLine = null;
                string CurrentSection = null;
                StreamWriter StreamW = new StreamWriter(@"c:\tmp.txt");

                while ((CurrentLine = StreamR.ReadLine()) != null)
                {
                    if (Regex.Match(CurrentLine, @"\[.+\]", RegexOptions.IgnoreCase).Success) // If the line is a new section
                    {
                        int tmpIndex = -1;
                        CurrentSection = CurrentLine.Trim();

                        if ((tmpIndex = CurrentSection.IndexOf(";")) != -1)
                        {
                            CurrentSection.Substring(0, tmpIndex);
                        }

                        CurrentSection = CurrentSection.Substring(1, CurrentSection.Length - 2); // We remove the first and last []

                        if (!CurrentSection.Equals(Section))
                        {
                            StreamW.WriteLine(CurrentLine);
                        }
                    }
                    else if (Regex.Match(CurrentLine, @".+=.+", RegexOptions.IgnoreCase).Success) // If the line contains an attribute
                    {
                        if (CurrentSection == null) // If there is no section, the file has a problem
                        {
                            throw new Exception("File is not well formated");
                        }
                        else if (!CurrentSection.Equals(Section)) // If we are not in the correct section, we print the line
                        {
                            StreamW.WriteLine(CurrentLine);
                        }
                    }
                }

                StreamW.Dispose();
            }

            // Then we removed to old file and replace it with the new one
            File.Copy(@"c:\tmp.txt", FileName, true);
            File.Delete(@"c:\tmp.txt");
        }
    }
}
