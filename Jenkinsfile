pipeline {
    
    agent any

    stages {

        stage('Cleaning Stage') {

            steps{
                
                echo "Deleting old files from IIS folder"
                //bat 'del /q "F:\\Jenkins\\Test\\*"'
            }
        }

        stage('SonarQube Analysis') {

            steps {
                def scannerHome = tool 'SonarQubeMSBuild'
                withSonarQubeEnv() {
                    bat "dotnet ${scannerHome}\\SonarScanner.MSBuild.dll begin /k:\"WebApp-Project\""
                    bat "dotnet build"
                    bat "dotnet ${scannerHome}\\SonarScanner.MSBuild.dll end"
                }
            }
        }

        stage('Build and Deploy Stage') {

            steps {

                echo "Building and Deploying Project on IIS"
                bat 'dotnet publish -c Release --self-contained true -p:PublishTrimmed=true -p:PublishDir=F:\\Jenkins\\DeclarativePipeline'     
            }
        }

        stage('Results') {
            
            steps {
                
                echo "Deployed Successfully on IIS"
            
            }
        }
    }
