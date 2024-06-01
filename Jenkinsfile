pipeline{
    agent any
    stages{
        stage('1 - Build ') {
            steps {
                script {
                    def isUnix = isUnix()
                    if (isUnix) {
                        sh 'echo "Running on Unix/Linux environment"'
                    } else {
                        bat 'echo "Running on Windows environment. "'
                        bat 'docker version'
                        bat 'docker info'
                        bat 'docker-compose version'
                        bat 'curl --version'
                        bat 'echo "verify tooling complete!! "'
                    }
                }
            }
        }
        
        stage('2 - Prune Docker Data') {
            steps {
                bat 'docker system prune -a --volumes -f'
            }
        }
        
        stage('3 - Start container') {
            steps {
                bat 'docker-compose up -d --no-color --wait'
                bat 'docker-compose ps'
            }
        }
    }
}