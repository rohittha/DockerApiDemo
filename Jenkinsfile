pipeline{
    agent any
    stages{
        stage("verify tooking"){
            steps{
                sh '''
                    docker version
                    docker info
                    docker compose version
                    curl --version
                    jq --version
                '''
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