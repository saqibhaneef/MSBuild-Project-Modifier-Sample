

using MSBuildProjectModifier.Managers;


namespace MSBuildProjectModifierSample
{
    internal class ConsoleMenu
    {
        private readonly IMsBuildManager msBuildManager;

        public ConsoleMenu(IMsBuildManager msBuildManager)
        {
            this.msBuildManager = msBuildManager;
        }
        public void ProjectModifier()
        {
            string projectPath = "D:\\Projects\\Sampl1\\Sample1.csproj";
            string reference = "Images\\Image.png";
            
            bool isProjectExists=this.msBuildManager.IsProjectExists(projectPath);

            if (isProjectExists)
            {
                bool isReferenceExists = this.msBuildManager.IsReferenceExists(projectPath, reference);
                if (isReferenceExists)
                {
                    bool isReferenceAdded = this.msBuildManager.AddReference(projectPath, "Images\\Image.png");
                }
            }

        }        
    }
}
