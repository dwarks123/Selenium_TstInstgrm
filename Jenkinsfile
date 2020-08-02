
import java.text.*
def Version = null
def FileName = null
def enableDeploy = 'true'
// Build Properties (num builds to keep, polling, blocking, etc)
properties([buildDiscarder(logRotator(artifactDaysToKeepStr: '30', artifactNumToKeepStr: '5', daysToKeepStr: '30', numToKeepStr: '5'))])

try
{
    timestamps
    {
        node('master')
        {
            stage('Set Version')
            {
                 def versionString = BRANCH_NAME+"."+BUILD_NUMBER
                
                 currentBuild.displayName = versionString
            }

            //pull the source code from git tfs.
            stage('check out')
            {
                // delete the existing source code to cleanup the workspace.
                deleteDir()
                // checkout the code from git tfs to the workspace.
                checkout scm
            }
             stage('Restore Packages')
            {    
                bat 'dotnet restore'

            }
            stage('Build Project')
            {                     
                bat 'dotnet build selnum.sln'
                   
            }
            stage('Zip the artifacts')
            {
                def archiveName = "${Version}.zip"
                powershell "Compress-Archive -Path Dist\\* -CompressionLevel Fastest -DestinationPath $workspace\\$archiveName"

                //artifactory.pushPackageToTRArtifactory("$Version", "pat/$BRANCH_NAME", "$BRANCH_NAME", "$archiveName")

                //bat "git tag -a -f -m $BRANCH_NAME-$BUILD_DISPLAY_NAME b$BRANCH_NAME-$BUILD_DISPLAY_NAME"
                //bat "git push -v ${git_vars.GIT_URL} --tags"
            }
			if(BRANCH_NAME.equals("devops1") || BRANCH_NAME.equals("develop"))
            {
                stage('Upload Artifacts for Veracode Scan')
                {
                    def packageName = "package.zip"
                    powershell "Compress-Archive -Path Dist\\* -CompressionLevel Fastest -DestinationPath $workspace\\$packageName"
                   // artifactory.pushPackageToTRArtifactory("$Version", "path/$BRANCH_NAME", "$BRANCH_NAME", "$packageName")

				
				}
               
            }
            
        }
    }
}
catch (e){
    echo e.getMessage()
    currentBuild.result = 'FAILURE'
    throw e
}