using System;
using System.IO;
using GatewayEDI.Logging;

namespace GatewayEDI.InternalApps.Common.Utilities
{
    public class SiteDirectoryManager
    {
        private static readonly ILog log = LogManager.GetLog(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Get Site Folder
        /// </summary>
        /// <param name="site">Siteid</param>
        /// <param name="sourceRoot">source path</param>
        /// <param name="destinationRoot">destination path</param>
        /// <returns>destination path</returns>
        public static string GetSiteFolder(string site, string sourceRoot, String destinationRoot)
        {
            try
            {
                var sourcePath = Path.Combine(sourceRoot, site);
                if (!Directory.Exists(sourcePath))
                {
                    throw new DirectoryNotFoundException(String.Format("No site directory found for site {0} at {1}.", site, sourceRoot));
                }

                var destinationPath = Path.Combine(destinationRoot, site);
                if (!Directory.Exists(destinationPath))
                {
                    CreateFolder(destinationPath);
                }

                CopySiteContent(sourcePath, destinationPath);
                return destinationPath;
            }
            catch (Exception ex)
            {
                log.Error(ex, "Unable to get the site folder");
                throw;
            }
        }

        /// <summary>
        /// Create Site Folder
        /// </summary>        
        /// <param name="folderFullName">destination Path</param>
        private static void CreateFolder(string folderFullName)
        {
            Directory.CreateDirectory(folderFullName);
        }

        /// <summary>
        /// Copy Site Content
        /// </summary>
        /// <param name="folderToCopy">source Path</param>
        /// <param name="destinationPath">destination Path</param>
        private static void CopySiteContent(string folderToCopy, string destinationPath)
        {
            var siteFolderToCopy = new DirectoryInfo(folderToCopy);

            foreach (var directory in siteFolderToCopy.GetDirectories("*CONV"))
            {
                CopyFolder(directory, destinationPath);
            }
            log.Info("Site folder got copied at {0}.", destinationPath);
        }

        /// <summary>
        /// Copy Folder
        /// </summary>
        /// <param name="sourcePath">source Path</param>
        /// <param name="destinationPath">destination Path</param>
        private static void CopyFolder(DirectoryInfo sourcePath, string destinationPath)
        {
            var destinationDirectory = Path.Combine(destinationPath, sourcePath.Name);

            if (!Directory.Exists(destinationDirectory))
                CreateFolder(destinationDirectory);

            foreach (var file in sourcePath.GetFiles())
            {               
                var destinationFile = Path.Combine(destinationDirectory, file.Name);
                if (!File.Exists(destinationFile))
                    file.CopyTo(destinationFile);
            }
        }
    }
}
