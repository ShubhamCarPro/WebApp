pipeline {
    
    agent any

    stages {

        stage('Cleaning Stage') {

            steps{
                
                echo "Deleting old files from IIS folder"
                bat 'del /q "F:\\Jenkins\\DeclarativePipeline\\*"'
            }
        }

        stage('Build and Test Stage') {

            steps {

                echo "Building and Testing Project on Local"
                bat '''dotnet sonarscanner begin /k:"test" /d:sonar.host.url="http://localhost:9000" /d:sonar.login="sqp_f481d943436efd89b2fc6660e357f49c18253a60"
                    dotnet build
                    dotnet sonarscanner end /d:sonar.login="sqp_f481d943436efd89b2fc6660e357f49c18253a60"'''   
            }
        }
        
        stage('Deploy Stage') {

            steps {

                echo "Deploying Project on IIS"
                bat 'dotnet publish -c Release --self-contained true -p:PublishTrimmed=true -p:PublishDir=F:\\Jenkins\\DeclarativePipeline'     
            }
        }

        stage('Results') {
            
            steps {
                
                echo "Deployed on IIS Server Successfully"
            
            }
        }
    }
}

/*node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def msbuildHome = tool 'MSBuild'
    def scannerHome = tool 'SonarQubeMSBuild'
    withSonarQubeEnv() {
      bat "\"${scannerHome}\\SonarScanner.MSBuild.exe\" begin /k:\"WebApp-Project\""
      bat "\"${msbuildHome}\\MSBuild.exe\" /t:Rebuild"
      echo "Done"
      bat "\"${scannerHome}\\SonarScanner.MSBuild.exe\" end"
    }
  }
}*/

/*node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def scannerHome = tool 'SonarQubeMSBuild'
    withSonarQubeEnv() {
      bat "dotnet ${scannerHome}\\SonarScanner.MSBuild.dll begin /k:\"WebApp-Project\""
      bat "dotnet build"
      bat "dotnet ${scannerHome}\\SonarScanner.MSBuild.dll end"
    }
  }
}*/
