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
    }
}