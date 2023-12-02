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
    }
}
