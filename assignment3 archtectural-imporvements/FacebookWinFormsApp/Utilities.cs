﻿using CefSharp.DevTools.CSS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal static class Utilities
    {
        public static string GetDefaultUserIdentifiers()
        {
            const string k_FileName = "decoupled_identifiers.txt";
            string projectSrcDir = ClimbDirectoryLevels("bin");
            string filePath = Path.Combine(projectSrcDir, k_FileName);

            if (File.Exists(filePath))
            {
                return File.ReadLines(filePath).FirstOrDefault();
            }
            else
            {
                return string.Empty;

            }
        }

        public static string ClimbDirectoryLevels(string i_ClimbStopper)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string binFolderPath = Path.Combine(currentDirectory, i_ClimbStopper);// A file or folder that signify stop

            while (!Directory.Exists(binFolderPath))
            {
                currentDirectory = Directory.GetParent(currentDirectory)?.FullName;
                binFolderPath = Path.Combine(currentDirectory, i_ClimbStopper);
            }

            return currentDirectory;
        }

        public static void AddAllItemsToListBox<T>(List<T> i_CollectionToAdd, ListBox i_ListBoxToFill)
        {
            foreach (T item in i_CollectionToAdd)
            {
                i_ListBoxToFill.Items.Add(item);
            }
        }

        public static void AssertPositive(int i_Number, 
            string i_ErrorMessage = null)
        {
            if (i_Number < 0)
            {
                string errorMessage = i_ErrorMessage == null
                    ? $"The number must be positive, got{i_Number}" : i_ErrorMessage;
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        public static T[] SwapInArray<T>(ref T[] io_Array, int idx1, int idx2)
        {
            T holder = io_Array[idx1];
            io_Array[idx1] = io_Array[idx2];
            io_Array[idx2] = holder;
            return io_Array;
        }

        public static void AssignToReadOnlyClass<T>(ref T io_Reference, T i_Argument)where T : class
        {
            if (io_Reference == null)
            {
                io_Reference = i_Argument;
            }
        }

    }
}
