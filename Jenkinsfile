pipeline {
    
  agent any

  stages {

    stage('Cleaning Stage') {

      steps{

        echo "Deleting old files from IIS folder"
        bat 'del /q "F:\\Jenkins\\Test\\*"'

      }
    }

    stage('Build and Deploy Stage') {

      steps {

        echo "Building and Deploying Project on IIS"
        bat 'dotnet publish -c Release --self-contained true -p:PublishTrimmed=true -p:PublishDir=F:\\Jenkins\\Test'

      }
    }

      stage('Results') {
        
        steps {
          
          echo "Deployed Successfully"

        }
      }
  }
}